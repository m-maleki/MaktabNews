using MaktabNews.Domain.Core.Contracts.AppServices;
using MaktabNews.Domain.Core.Dtos.Reporter;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaktabNews.WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ReporterController : ControllerBase
    {
        private readonly IReporterAppServices _reporterAppServices;

        public ReporterController(IReporterAppServices reporterAppServices)
        {
            _reporterAppServices = reporterAppServices;
        }

        [HttpGet]
        [Route(nameof(GetSummary))]
        public async Task<ReporterSummeryDto> GetSummary(int id,CancellationToken cancellationToken)
        {
            return await _reporterAppServices.GetSummery(id, cancellationToken);
        }
    }
}
