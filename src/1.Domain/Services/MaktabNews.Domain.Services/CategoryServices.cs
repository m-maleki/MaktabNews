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

        public async Task<List<CategoryMenuDto>> GetCategoriesForMenu(CancellationToken cancellationToken)
            => await _categoryRepository.GetCategoriesForMenu(cancellationToken);

        public async Task<List<CategoryWithCountDto>> GetCategoriesWithCount(CancellationToken cancellationToken)
            => await _categoryRepository.GetCategoriesWithCount(cancellationToken);

        public async Task Create(string title, CancellationToken cancellationToken)
            => await _categoryRepository.Create(title, cancellationToken);

        public async Task Delete(int id, CancellationToken cancellationToken)
            => await _categoryRepository.Delete(id, cancellationToken);

        public async Task<string> GetById(int id, CancellationToken cancellationToken)
            => await _categoryRepository.GetById(id, cancellationToken);

        public async Task Update(int id, string title, CancellationToken cancellationToken)
            => await _categoryRepository.Update(id, title, cancellationToken);
    }
}
