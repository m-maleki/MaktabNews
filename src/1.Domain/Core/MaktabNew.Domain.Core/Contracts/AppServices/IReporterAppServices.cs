using MaktabNews.Domain.Core.Dtos.Reporter;

namespace MaktabNews.Domain.Core.Contracts.AppServices
{
    public interface IReporterAppServices
    {
        Task<ReporterSummeryDto> GetSummery(int id,CancellationToken cancellationToken);
    }
}
