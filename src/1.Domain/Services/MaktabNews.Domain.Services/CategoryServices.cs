using MaktabNews.Domain.Core.Contracts.Repository;
using MaktabNews.Domain.Core.Contracts.Services;
using MaktabNews.Domain.Core.Dtos.Category;

namespace MaktabNews.Domain.Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryServices(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public List<CategoryMenuDto> GetCategoriesForMenu()
            => _categoryRepository.GetCategoriesForMenu();

        public List<CategoryWithCountDto> GetCategoriesWithCount()
            => _categoryRepository.GetCategoriesWithCount();
    }
}
