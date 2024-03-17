using MaktabNews.Domain.Core.Contracts.Repository;
using MaktabNews.Domain.Core.Contracts.Services;
using MaktabNews.Domain.Core.Dtos.Reporter;

namespace MaktabNews.Domain.Services
{
    public class ReporterServices : IReporterServices
    {
        private readonly IReporterRepository _reporterRepository;

        public ReporterServices(IReporterRepository reporterRepository)
        {
            _reporterRepository = reporterRepository;
        }

        public ReporterSummeryDto GetSummery(int id)
        {
            return _reporterRepository.GetSummery(id);
        }
    }
}
