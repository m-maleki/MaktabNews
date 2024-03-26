using Microsoft.AspNetCore.Mvc;
using MaktabNews.Domain.Core.Dtos.Tag;
using MaktabNews.Domain.Core.Contracts.AppServifces;

namespace MaktabNews.WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly ITagAppServices _tagAppServices;

        public TagController(ITagAppServices tagAppServices)
        {
            _tagAppServices = tagAppServices;
        }

        [HttpGet]
        [Route(nameof(GetAll))]
        public List<TagViewDto> GetAll()
        {
            return _tagAppServices.GetAll();
        }
    }
}