using System.Net.Http.Headers;
using MaktabNews.Domain.Core.Contracts.Repository;
using MaktabNews.Domain.Core.Contracts.Services;
using MaktabNews.Domain.Core.Dtos.Reporter;
using System.Threading;
using Microsoft.AspNetCore.Http;

namespace MaktabNews.Domain.Services
{
    public class ReporterServices : IReporterServices
    {
        private readonly IReporterRepository _reporterRepository;

        public ReporterServices(IReporterRepository reporterRepository)
        {
            _reporterRepository = reporterRepository;
        }

        public async Task<ReporterSummeryDto> GetSummery(int id, CancellationToken cancellationToken)
        {
            return await _reporterRepository.GetSummery(id, cancellationToken);
        }

        public async Task Update(UpdateReporterDto model, CancellationToken cancellationToken)
        {
            await _reporterRepository.Update(model, cancellationToken);
        }

        public async Task<string> UploadImageProfile(IFormFile FormFile, CancellationToken cancellationToken)
        {
            string filePath;
            string fileName;
            if (FormFile != null)
            {
                fileName = Guid.NewGuid().ToString() +
                           ContentDispositionHeaderValue.Parse(FormFile.ContentDisposition).FileName.Trim('"');
                filePath = Path.Combine("wwwroot/Images/Reporters", fileName);
                try
                {
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await FormFile.CopyToAsync(stream);
                    }
                }
                catch
                {
                    throw new Exception("Upload files operation failed");
                }
                return $"/Images/Reporters/{fileName}";
            }
            else
                fileName = "";

            return fileName;
        }
    }
}
