using MaktabNews.Domain.Core.Contracts.AppServifces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MaktabNews.RazorPages.Areas.Admin.Pages.Category
{
    public class UpdateModel : PageModel
    {

        private readonly ICategoryAppServices _categoryAppServices;

        public UpdateModel(ICategoryAppServices categoryAppServices)
        {
            _categoryAppServices = categoryAppServices;
        }

        [BindProperty]
        public string CategoryName { get; set; }

        [BindProperty]
        public int Id { get; set; }


        public async Task OnGet(int id, CancellationToken cancellationToken)
        {
            CategoryName = await _categoryAppServices.GetById(id, cancellationToken);
            Id = id;
        }

        public async Task<IActionResult> OnPost(CancellationToken cancellationToken)
        {
            await _categoryAppServices.Update(Id, CategoryName, cancellationToken);
            return RedirectToPage("Index");
        }
    }
}
