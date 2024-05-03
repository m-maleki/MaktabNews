using MaktabNews.Domain.Core.Contracts.AppServifces;
using MaktabNews.Domain.Core.Dtos.News;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MaktabNews.Pages
{
    public class IndexModel : PageModel
    {
        private readonly INewsAppServices _newsAppServices;
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public List<NewsSummeryDto> News { get; set; }

        public IndexModel(INewsAppServices newsAppServices, ILogger<IndexModel> logger)
        {
            _newsAppServices = newsAppServices;
            _logger = logger;
        }

        public async Task OnGet(CancellationToken cancellationToken)
        {
            _logger.LogInformation("This is test log");
            News = await _newsAppServices.GetAll(cancellationToken);
        }
    }
}