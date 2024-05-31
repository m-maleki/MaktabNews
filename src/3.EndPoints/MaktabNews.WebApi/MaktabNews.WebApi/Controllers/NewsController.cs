using Microsoft.AspNetCore.Mvc;
using MaktabNews.Domain.Core.Dtos.News;
using MaktabNews.Domain.Core.Contracts.AppServifces;

namespace MaktabNews.WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsAppServices _newsAppServices;

        public NewsController(INewsAppServices newsAppServices)
        {
            _newsAppServices = newsAppServices;
        }

        [HttpGet]
        [Route(nameof(GetAll))]
        public async Task<List<NewsSummeryDto>> GetAll(CancellationToken cancellationToken)
        {
            return await _newsAppServices.GetAll(cancellationToken);
        }

        [HttpGet]
        [Route(nameof(GetDetail))]
        public async Task<NewsDetailsDto> GetDetail(int id,CancellationToken cancellationToken)
        {
            return await _newsAppServices.GetDetails(id, cancellationToken);
        }


        [HttpGet]
        [Route(nameof(GetRecent))]
        public async Task<List<NewsRecentDto>> GetRecent(CancellationToken cancellationToken)
        {
            return await _newsAppServices.GetRecent(cancellationToken);
        }


    }
}
