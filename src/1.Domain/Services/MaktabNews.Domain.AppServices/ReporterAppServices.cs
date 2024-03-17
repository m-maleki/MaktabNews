using MaktabNews.Domain.Core.Contracts.AppServices;
using MaktabNews.Domain.Core.Contracts.Services;
using MaktabNews.Domain.Core.Dtos.Reporter;

namespace MaktabNews.Domain.AppServices
{
    public class ReporterAppServices : IReporterAppServices
    {
        private readonly IReporterServices _reporterServices;

        public ReporterAppServices(IReporterServices reporterServices)
        {
            _reporterServices = reporterServices;
        }

        public ReporterSummeryDto GetSummery(int id)
        {
            return _reporterServices.GetSummery(id);
        }
    }
}
