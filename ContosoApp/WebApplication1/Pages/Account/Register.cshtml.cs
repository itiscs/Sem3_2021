using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Pages.Account
{
    public class Rmodel
    {
        [Required(ErrorMessage = "�� ������ Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "�� ������ ������")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "������ ������ �������")]
        public string ConfirmPassword { get; set; }
    }

    [ValidateAntiForgeryToken]
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public Rmodel Rmodel { get; set; }

        private SchoolContext db;
        public RegisterModel(SchoolContext context)
        {
            db = context;

        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        { 
            if (ModelState.IsValid)
            {
                User user = await db.Users.FirstOrDefaultAsync(u => u.Email == Rmodel.Email);
                if (user == null)
                {
                    // ��������� ������������ � ��
                    db.Users.Add(new User { Email = Rmodel.Email, Password = Rmodel.Password });
                    await db.SaveChangesAsync();

                    await Authenticate(Rmodel.Email); // ��������������

                    if (Request.Query.ContainsKey("ReturnUrl"))
                        return Redirect(Request.Query["ReturnUrl"]);

                    return RedirectToPage("/Index");
                }
                else
                    ModelState.AddModelError("", "������������ ����� �(���) ������");
            }
            return Page();
        }


        private async Task Authenticate(string userName)
        {
            // ������� ���� claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            // ������� ������ ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // ��������� ������������������ ����
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}
