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

        public async Task<List<CategoryMenuDto>> GetCategoriesForMenu(CancellationToken cancellationToken)
            => await _categoryServices.GetCategoriesForMenu(cancellationToken);

        public async Task<List<CategoryWithCountDto>> GetCategoriesWithCount(CancellationToken cancellationToken)
            => await _categoryServices.GetCategoriesWithCount(cancellationToken);
    }
}
