using MaktabNews.Domain.Core.Contracts.AppServifces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MaktabNews.RazorPages.Areas.Admin.Pages.Category
{
    public class CreateModel : PageModel
    {
        private readonly ICategoryAppServices _categoryAppServices;

        public CreateModel(ICategoryAppServices categoryAppServices)
        {
            _categoryAppServices = categoryAppServices;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(string categoryName,CancellationToken cancellationToken)
        {
            await _categoryAppServices.Create(categoryName, cancellationToken);
            return RedirectToPage("Index");
        }


    }
}
