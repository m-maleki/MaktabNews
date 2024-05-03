using MaktabNews.Domain.Core.Dtos.Category;

namespace MaktabNews.Domain.Core.Contracts.Repository
{
    public interface ICategoryRepository
    {
        Task<List<CategoryMenuDto>> GetCategoriesForMenu(CancellationToken cancellationToken);
        Task<List<CategoryWithCountDto>> GetCategoriesWithCount(CancellationToken cancellationToken);
    }
}
