using MaktabNews.Domain.Core.Contracts.AppServices;
using MaktabNews.Domain.Core.Contracts.Services;
using MaktabNews.Domain.Core.Dtos.Reporter;
using Microsoft.AspNetCore.Http;

namespace MaktabNews.Domain.AppServices
{
    public class ReporterAppServices : IReporterAppServices
    {
        private readonly IReporterServices _reporterServices;

        public ReporterAppServices(IReporterServices reporterServices)
        {
            _reporterServices = reporterServices;
        }

        public async Task<ReporterSummeryDto> GetSummery(int id, CancellationToken cancellationToken)
        {
            return await _reporterServices.GetSummery(id, cancellationToken);
        }

        public async Task Update(UpdateReporterDto model,IFormFile file, CancellationToken cancellationToken)
        {
            if (file is not null)
            {
                var ImageAddress = await _reporterServices.UploadImageProfile(file, cancellationToken);

                model.ImageAddress = ImageAddress;
            }

            await _reporterServices.Update(model, cancellationToken);
        }
    }
}
