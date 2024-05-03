using MaktabNews.Domain.Core.Dtos.Category;

namespace MaktabNews.Domain.Core.Contracts.Services
{
    public interface ICategoryServices
    {
        Task<List<CategoryMenuDto>> GetCategoriesForMenu(CancellationToken cancellationToken);
        Task<List<CategoryWithCountDto>> GetCategoriesWithCount(CancellationToken cancellationToken);

    }
}
