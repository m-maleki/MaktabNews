using MaktabNews.Domain.Core.Contracts.AppServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace MaktabNews.RazorPages.Areas.Account.Pages
{
    public class LoginModel : PageModel
    {

        private readonly IAccountAppServices _accountAppServices;

        public LoginModel(IAccountAppServices accountAppServices)
        {
            _accountAppServices = accountAppServices;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            public string Email { get; set; }

            [Required]
            public string Password { get; set; }

        }



        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {

            returnUrl ??= Url.Content("~/");

            if (!ModelState.IsValid) return Page();

            var succeededLogin = await _accountAppServices.Login(Input.Email, Input.Password);

            if (succeededLogin)
                return LocalRedirect(returnUrl);

            else
            {
                ModelState.AddModelError(string.Empty, "نام کاربری یا کلمه عبور اشتباه است");
                return Page();
            }

        }

    }
}
