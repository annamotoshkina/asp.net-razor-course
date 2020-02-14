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
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public DeleteModel(ApplicationDbContext db)
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
            var userInDb = await _db.ApplicationUser.SingleOrDefaultAsync(u => u.Id == ApplicationUser.Id);
            _db.ApplicationUser.Remove(userInDb);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}