using System.ComponentModel.DataAnnotations;
using MaktabNews.Domain.Core.Contracts.AppServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MaktabNews.RazorPages.Areas.Identity.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly IAccountAppServices _accountAppServices;

        public RegisterModel(IAccountAppServices accountAppServices)
        {
            _accountAppServices = accountAppServices;
        }

        [BindProperty]
        public InputModel Input { get; set; }


        public class InputModel
        {
            public string Email { get; set; }
            public string Password { get; set; }
            public bool IsReporter { get; set; }
            public bool IsVisitor { get; set; }
            public string PhoneNumber { get; set; }
        }


        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            if (Input.IsReporter && Input.IsVisitor)
            {
                ModelState.AddModelError(string.Empty, "همزمان نمیتوانید هم خبرنگار باشید هم بیننده خبر");
                return Page();
            }

            returnUrl ??= Url.Content("~/");

            var result = await _accountAppServices.Register(Input.Email, Input.Password,
                Input.IsReporter, Input.IsVisitor,Input.PhoneNumber);

            if (result.Count == 0)
            {
                return LocalRedirect(returnUrl);
            }

            foreach (var error in result)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return Page();

        }

    }

}
