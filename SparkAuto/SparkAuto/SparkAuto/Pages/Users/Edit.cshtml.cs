using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SparkAuto.Data;
using SparkAuto.Models;
using SparkAuto.Utility;

namespace SparkAuto.Pages.Users
{
    [Authorize(Roles = SD.AdminEndUser)]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public ApplicationUser ApplicationUser { get; set; }

        public async Task<IActionResult> OnGet(string Id)
        {
            ApplicationUser = _db.ApplicationUser.Where(q => q.Id == Id).FirstOrDefault();
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var userInDb = await _db.ApplicationUser.SingleOrDefaultAsync(u => u.Id == ApplicationUser.Id);

            try
            {
                userInDb.Name = ApplicationUser.Name;
                userInDb.PhoneNumber = ApplicationUser.PhoneNumber;
                userInDb.Address = ApplicationUser.Address;
                userInDb.City = ApplicationUser.City;
                userInDb.PostalCode = ApplicationUser.PostalCode;
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(ApplicationUser.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool UserExists(string id)
        {
            return _db.ApplicationUser.Any(e => e.Id == id);
        }
    }
}