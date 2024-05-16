using MaktabNews.Domain.Core.Contracts.AppServices;
using MaktabNews.RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MaktabNews.RazorPages.Areas.Identity.Pages.Account
{
    public class LoginModel : PageModel
    {

        private readonly IAccountAppServices _accountAppServices;

        public LoginModel(IAccountAppServices accountAppServices)
        {
            _accountAppServices = accountAppServices;
        }

        [BindProperty]
        public LoginDto LoginDto { get; set; }

        public void OnGet()
        {
        }

        public async Task OnPost(CancellationToken cancellationToken)
        {
            var result = await _accountAppServices.Login(LoginDto.Email, LoginDto.Password);

        }

    }
}
