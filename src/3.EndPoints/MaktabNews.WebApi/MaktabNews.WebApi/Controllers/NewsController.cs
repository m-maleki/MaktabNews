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
        public List<NewsSummeryDto> GetAll()
        {
            return _newsAppServices.GetAll();
        }

        [HttpGet]
        [Route(nameof(GetDetail))]
        public NewsDetailsDto GetDetail(int id)
        {
            return _newsAppServices.GetDetails(id);
        }


        [HttpGet]
        [Route(nameof(GetRecent))]
        public List<NewsRecentDto> GetRecent()
        {
            return _newsAppServices.GetRecent(5);
        }
    }
}
