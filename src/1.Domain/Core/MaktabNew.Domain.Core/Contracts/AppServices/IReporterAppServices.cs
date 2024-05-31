using MaktabNews.Domain.Core.Dtos.Reporter;
using Microsoft.AspNetCore.Http;

namespace MaktabNews.Domain.Core.Contracts.AppServices
{
    public interface IReporterAppServices
    {
        Task<ReporterSummeryDto> GetSummery(int id,CancellationToken cancellationToken);
        Task Update(UpdateReporterDto model, IFormFile file, CancellationToken cancellationToken);
    }
}
