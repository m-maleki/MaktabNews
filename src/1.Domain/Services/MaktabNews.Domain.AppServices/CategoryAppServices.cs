using MaktabNews.Domain.Core.Contracts.AppServifces;
using MaktabNews.Domain.Core.Contracts.Services;
using MaktabNews.Domain.Core.Dtos.Category;

namespace MaktabNews.Domain.AppServices
{
    public class CategoryAppServices : ICategoryAppServices
    {
        private readonly ICategoryServices _categoryServices;

        public CategoryAppServices(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        public List<CategoryMenuDto> GetCategoriesForMenu()
            => _categoryServices.GetCategoriesForMenu();

        public List<CategoryWithCountDto> GetCategoriesWithCount()
            => _categoryServices.GetCategoriesWithCount();
    }
}
