using MaktabNews.Domain.Core.Dtos.Reporter;

namespace MaktabNews.Domain.Core.Contracts.Repository
{
    public interface IReporterRepository
    {
        public ReporterSummeryDto GetSummery(int id);
    }
}
