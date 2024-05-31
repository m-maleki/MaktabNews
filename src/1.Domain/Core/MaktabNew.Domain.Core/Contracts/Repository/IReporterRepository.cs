using MaktabNews.Domain.Core.Dtos.Reporter;

namespace MaktabNews.Domain.Core.Contracts.Repository
{
    public interface IReporterRepository
    {
        Task<ReporterSummeryDto> GetSummery(int id, CancellationToken cancellationToken);
        Task Update(UpdateReporterDto model,CancellationToken cancellationToken);
    }

}
