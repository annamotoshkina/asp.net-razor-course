using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SparkAuto.Data;
using SparkAuto.Model;
using SparkAuto.Model.ViewModel;
using SparkAuto.Utility;

namespace SparkAuto.Pages.Users
{
    [Authorize(Roles = SD.AdminEndUser)]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public UserListViewModel UserListViewModel { get; set; }

        public async Task<IActionResult> OnGet(int productPage = 1, string searchEmail = null, string searchName = null, string searchPhone = null)
        {
            UserListViewModel = new UserListViewModel()
            {
                ApplicationUserList = await _db.ApplicationUser
                    .Where(q => (searchEmail == null || q.Email.ToLower().Contains(searchEmail.ToLower())) &&
                        (searchName == null || q.Name.ToLower().Contains(searchName.ToLower())) &&
                        (searchPhone == null || q.PhoneNumber.ToLower().Contains(searchPhone.ToLower())))
                    .ToListAsync()
            };

            StringBuilder param = new StringBuilder();
            param.Append("/Users?productPage=:");
            param.Append("&searchName=");
            if (searchName != null)
            {
                param.Append(searchName);
            }
            param.Append("&searchEmail=");
            if (searchEmail != null)
            {
                param.Append(searchEmail);
            }
            param.Append("&searchPhone=");
            if (searchPhone != null)
            {
                param.Append(searchPhone);
            }

            UserListViewModel.PagingInfo = new PagingInfo()
            {
                CurrentPage = productPage,
                ItemsPerPage = SD.PaginationUsersPageSize,
                TotalItems = UserListViewModel.ApplicationUserList.Count,
                UrlParam = param.ToString(),
            };

            UserListViewModel.ApplicationUserList = UserListViewModel.ApplicationUserList.OrderBy(p => p.Email)
                .Skip((productPage - 1) * SD.PaginationUsersPageSize).Take(SD.PaginationUsersPageSize).ToList();

            return Page();
        }
    }
}