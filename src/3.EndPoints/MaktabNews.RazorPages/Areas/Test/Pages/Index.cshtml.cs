using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MaktabNews.RazorPages.Areas.Test.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet(string returnUrl = null)
        {

        }

        [HttpPost]
        public async Task OnPostAsync(string returnUrl = null)
        {

        }
    }
}
