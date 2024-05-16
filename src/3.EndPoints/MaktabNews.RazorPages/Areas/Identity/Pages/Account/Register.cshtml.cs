using MaktabNews.Domain.Core.Contracts.AppServices;
using MaktabNews.RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MaktabNews.RazorPages.Areas.Identity.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly IAccountAppServices _accountAppServices;

        public RegisterModel(IAccountAppServices accountAppServices)
        {
            _accountAppServices = accountAppServices;
        }

        [BindProperty]
        public RegisterViewModel RegisterViewModel { get; set; }

        public void OnGet()
        {
        }

        public async Task OnPost(CancellationToken cancellationToken)
        {
            await _accountAppServices.Register(RegisterViewModel.Email, RegisterViewModel.Password,
                RegisterViewModel.IsReporter , RegisterViewModel.IsVisitor);
        }
    }
}
