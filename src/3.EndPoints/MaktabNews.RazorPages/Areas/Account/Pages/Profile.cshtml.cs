using MaktabNews.Domain.Core.Contracts.AppServices;
using MaktabNews.Domain.Core.Dtos.Reporter;
using MaktabNews.Domain.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MaktabNews.RazorPages.Areas.Account.Pages
{
    [Authorize(Roles = "Visitor,Reporter")]
    public class ProfileModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IReporterAppServices _reporterAppServices;

        [BindProperty]
        public ViewModel InputModel { get; set; }


        public ProfileModel(UserManager<ApplicationUser> userManager,
            IReporterAppServices reporterAppServices)
        {
            _userManager = userManager;
            _reporterAppServices = reporterAppServices;
        }


        public class ViewModel
        {
            public int Id { get; set; }
            public string AboutMe { get; set; }
            public string? ImageAddress { get; set; }
            public string FullName { get; set; }
            public string? Address { get; set; }
            public IFormFile? ProfileImgFile { get; set; }
            public List<int>? CategoryIds { get; set; }

        }

        public async Task<IActionResult> OnPostAsync(CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                await _reporterAppServices.Update(new UpdateReporterDto()
                {
                    AppUserId = InputModel.Id,
                    FullName = InputModel.FullName,
                    AboutMe = InputModel.AboutMe,
                    Address = InputModel.Address,
                    Categories = InputModel.CategoryIds,
                    ImageAddress = InputModel.ImageAddress
                },InputModel.ProfileImgFile, cancellationToken);
            }

            return LocalRedirect("~/Account/Profile");
        }

        public async Task OnGet(CancellationToken cancellationToken)
        {
            var userId = int.Parse(User.Claims.First().Value);


            if (User.IsInRole("Visitor"))
            {

            }

            if (User.IsInRole("Reporter"))
            {
                var ReporterSummery = await _reporterAppServices.GetSummery(userId, cancellationToken);

                ViewData["ImageAddress"] = ReporterSummery.ImageAddress;

                    InputModel = new ViewModel()
                    {
                        Id = ReporterSummery.Id,
                        FullName = ReporterSummery.FullName,
                        Address = ReporterSummery.Address,
                        AboutMe = ReporterSummery.AboutMe,
                        ImageAddress = ReporterSummery.ImageAddress,
                        CategoryIds = ReporterSummery.CategoryIds
                    };
               
            }
        }

    }
}
