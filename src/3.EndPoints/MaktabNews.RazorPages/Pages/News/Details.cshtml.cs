using MaktabNews.Domain.Core.Contracts.AppServices;
using MaktabNews.Domain.Core.Contracts.AppServifces;
using MaktabNews.Domain.Core.Dtos.Comment;
using MaktabNews.Domain.Core.Dtos.News;
using MaktabNews.Domain.Core.Dtos.Reporter;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MaktabNews.RazorPages.Pages.News
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly INewsAppServices _newsAppServices;
        private readonly IReporterAppServices _reporterAppServices;
        private readonly ICommentAppServices _commentAppServices;

        public DetailsModel(INewsAppServices newsAppServices,
            IReporterAppServices reporterAppServices,
            ICommentAppServices commentAppServices)
        {
            _newsAppServices = newsAppServices;
            _reporterAppServices = reporterAppServices;
            _commentAppServices = commentAppServices;
        }

        [BindProperty]
        public NewsDetailsDto News { get; set; }

        [BindProperty]
        public ReporterSummeryDto Reporter { get; set; }

        [BindProperty]
        public string Description { get; set; }



        public async Task OnGet(int id, CancellationToken cancellationToken)
        {
            News = await _newsAppServices.GetDetails(id, cancellationToken);
            Reporter = await _reporterAppServices.GetSummery(News.ReporterId, cancellationToken);
        }

        public async Task<IActionResult> OnPost(CancellationToken cancellationToken)
        {
            if (User.IsInRole("Visitor"))
            {
                var model = new CreateCommentDto()
                {
                    Description = Description,
                    UserId = int.Parse(User.Claims.First().Value),
                    NewsId = News.Id
                };

                await _commentAppServices.Create(model, cancellationToken);
            }

            return LocalRedirect($"/News/Details?id={News.Id}");
        }
    }
}
