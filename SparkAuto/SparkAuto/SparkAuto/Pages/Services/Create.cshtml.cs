using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SparkAuto.Data;
using SparkAuto.Model;
using SparkAuto.Models;
using SparkAuto.Models.ViewModel;
using SparkAuto.Utility;

namespace SparkAuto.Pages.Services
{
    [Authorize(Roles = SD.AdminEndUser)]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public CarServiceViewModel CarServiceViewModel { get; set; }

        public CreateModel (ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> OnGet(int carId)
        {
            CarServiceViewModel = new CarServiceViewModel
            {
                Car = await _db.Car.Include(c => c.ApplicationUser).FirstOrDefaultAsync(c => c.Id == carId),
                ServiceHeader = new Models.ServiceHeader(),
            };

            List<string> ServiceTypesInShoppingCart = _db.ServiceShoppingCart
                .Include(c => c.ServiceType)
                .Where(c => c.CarId == carId)
                .Select(c => c.ServiceType.Name)
                .ToList();

            IQueryable<ServiceType> Services = from s in _db.ServiceType
                                               where !(ServiceTypesInShoppingCart.Contains(s.Name))
                                               select s;

            CarServiceViewModel.ServiceTypesList = Services.ToList();

            CarServiceViewModel.ServiceShoppingCart = _db.ServiceShoppingCart.Include(c => c.ServiceType).Where(c => c.CarId == carId).ToList();
            CarServiceViewModel.ServiceHeader.TotalPrice = 0;
            foreach (var item in CarServiceViewModel.ServiceShoppingCart)
            {
                CarServiceViewModel.ServiceHeader.TotalPrice += item.ServiceType.Price;
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                CarServiceViewModel.ServiceHeader.DateAdded = DateTime.Now;
                CarServiceViewModel.ServiceShoppingCart = _db.ServiceShoppingCart.Include(c => c.ServiceType).Where(c => c.CarId == CarServiceViewModel.Car.Id).ToList();
                foreach (var item in CarServiceViewModel.ServiceShoppingCart)
                {
                    CarServiceViewModel.ServiceHeader.TotalPrice += item.ServiceType.Price;
                }
                CarServiceViewModel.ServiceHeader.CarId = CarServiceViewModel.Car.Id;

                _db.ServiceHeader.Add(CarServiceViewModel.ServiceHeader);
                await _db.SaveChangesAsync();

                foreach (var detail in CarServiceViewModel.ServiceShoppingCart)
                {
                    ServiceDetails serviceDetails = new ServiceDetails
                    {
                        ServicHeaderId = CarServiceViewModel.ServiceHeader.Id,
                        ServiceName = detail.ServiceType.Name,
                        ServicePrice = detail.ServiceType.Price,
                        ServiceTypeId = detail.ServiceTypeId
                    };

                    _db.ServiceDetails.Add(serviceDetails);

                }
                _db.ServiceShoppingCart.RemoveRange(CarServiceViewModel.ServiceShoppingCart);

                await _db.SaveChangesAsync();

                return RedirectToPage("../Cars/Index", new { userId = CarServiceViewModel.Car.UserId });
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAddToCart()
        {
            ServiceShoppingCart objServiceCart = new ServiceShoppingCart()
            {
                CarId = CarServiceViewModel.Car.Id,
                ServiceTypeId = CarServiceViewModel.ServiceDetails.ServiceTypeId
            };

            _db.ServiceShoppingCart.Add(objServiceCart);
            await _db.SaveChangesAsync();
            return RedirectToPage("Create", new { carId = CarServiceViewModel.Car.Id });
        }

        public async Task<IActionResult> OnPostRemoveFromCart(int serviceTypeId)
        {
            ServiceShoppingCart objServiceCart = _db.ServiceShoppingCart
                .FirstOrDefault(u => u.CarId == CarServiceViewModel.Car.Id && u.ServiceTypeId == serviceTypeId);

            _db.ServiceShoppingCart.Remove(objServiceCart);
            await _db.SaveChangesAsync();
            return RedirectToPage("Create", new { carId = CarServiceViewModel.Car.Id });
        }
    }
}