using MaktabNews.Domain.Core.Contracts.Repository;
using MaktabNews.Domain.Core.Contracts.Services;
using MaktabNews.Domain.Core.Dtos.Reporter;
using System.Threading;

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
    }
}
