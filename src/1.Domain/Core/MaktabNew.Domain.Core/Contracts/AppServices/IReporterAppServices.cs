using MaktabNews.Domain.Core.Dtos.Reporter;

namespace MaktabNews.Domain.Core.Contracts.AppServices
{
    public interface IReporterAppServices
    {
        public ReporterSummeryDto GetSummery(int id);
    }
}
