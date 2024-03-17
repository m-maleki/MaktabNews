using MaktabNews.Domain.Core.Contracts.AppServifces;
using MaktabNews.Domain.Core.Dtos.News;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MaktabNews.Pages
{
    public class IndexModel : PageModel
    {
        private readonly INewsAppServices _newsAppServices;

        [BindProperty]
        public List<NewsSummeryDto> News { get; set; }

        public IndexModel(INewsAppServices newsAppServices)
        {
            _newsAppServices = newsAppServices;
        }

        public void OnGet()
        {
            News = _newsAppServices.GetAll();
        }
    }
}