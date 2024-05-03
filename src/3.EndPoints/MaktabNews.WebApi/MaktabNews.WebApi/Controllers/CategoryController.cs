using MaktabNews.Domain.Core.Contracts.AppServifces;
using MaktabNews.Domain.Core.Dtos.Category;
using Microsoft.AspNetCore.Mvc;

namespace MaktabNews.WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryAppServices _categoryAppServices;

        public CategoryController(ICategoryAppServices categoryAppServices)
        {
            _categoryAppServices = categoryAppServices;
        }

        [HttpGet]
        [Route(nameof(GetCategoriesForMenu))]
        public async Task<List<CategoryMenuDto>> GetCategoriesForMenu(CancellationToken cancellationToken)
        {
            return await _categoryAppServices.GetCategoriesForMenu(cancellationToken);
        }

        [HttpGet]
        [Route(nameof(GetCategoriesWithCount))]
        public async Task<List<CategoryWithCountDto>> GetCategoriesWithCount(CancellationToken cancellationToken)
        {
            return await _categoryAppServices.GetCategoriesWithCount(cancellationToken);
        }
    }
}
