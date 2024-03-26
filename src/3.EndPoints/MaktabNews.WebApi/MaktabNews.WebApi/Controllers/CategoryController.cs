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
        public List<CategoryMenuDto> GetCategoriesForMenu()
        {
            return _categoryAppServices.GetCategoriesForMenu();
        }

        [HttpGet]
        [Route(nameof(GetCategoriesWithCount))]
        public List<CategoryWithCountDto> GetCategoriesWithCount()
        {
            return _categoryAppServices.GetCategoriesWithCount();
        }
    }
}
