using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SparkAuto.Data;

namespace SparkAuto.Areas.Identity.Pages.Account
{
    public class VerifyEmailModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _db;
        private readonly IEmailSender _emailSender;

        public VerifyEmailModel(UserManager<IdentityUser> userManager, ApplicationDbContext db, IEmailSender emailSender)
        {
            _userManager = userManager;
            _db = db;
            _emailSender = emailSender;
        }

        [BindProperty]
        public string Email { get; set; }

        public IActionResult OnGet(string id)
        {
            Email = id;
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (Email != null)
            {
                var user = _db.Users.FirstOrDefault(u => u.Email == Email);

                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var callbackUrl = Url.Page(
                    "/Account/ConfirmEmail",
                    pageHandler: null,
                    values: new { userId = user.Id, code = code },
                    protocol: Request.Scheme);

                await _emailSender.SendEmailAsync(Email, "Confirm your email",
                    $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

            }

            return RedirectToPage("Login");
        }
    }
}
