using MaktabNews.Domain.AppServices;
using MaktabNews.Domain.Core.Contracts.AppServifces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MaktabNews.RazorPages.Areas.Admin.Pages.Category
{
    public class IndexModel : PageModel
    {
        private readonly ICategoryAppServices _categoryAppServices;

        public IndexModel(ICategoryAppServices categoryAppServices)
        {
            _categoryAppServices = categoryAppServices;
        }


        public void OnGet()
        {

        }

        public async Task OnGetDelete(int id, CancellationToken cancellationToken)
        {
            await _categoryAppServices.Delete(id, cancellationToken);
        }
    }
}
