using MaktabNews.Domain.Core.Contracts.AppServices;
using MaktabNews.Domain.Core.Dtos.Reporter;
using MaktabNews.Domain.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MaktabNews.RazorPages.Areas.Account.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IReporterAppServices _reporterAppServices;

        [BindProperty]
        public ReporterSummeryDto ReporterSummery { get; set; }

        public ProfileModel(UserManager<ApplicationUser> userManager,
            IReporterAppServices reporterAppServices)
        {
            _userManager = userManager;
            _reporterAppServices = reporterAppServices;
        }

        public async Task OnGet(CancellationToken cancellationToken)
        {
            var userId = int.Parse(User.Claims.First().Value);

            if (User.IsInRole("Visitor"))
            {

            }

            if (User.IsInRole("Reporter"))
            {
                ReporterSummery = await _reporterAppServices.GetSummery(userId, cancellationToken);
            }
        }
    }
}
