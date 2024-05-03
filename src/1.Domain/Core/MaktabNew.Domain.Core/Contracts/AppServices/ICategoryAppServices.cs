using MaktabNews.Domain.Core.Dtos.Category;

namespace MaktabNews.Domain.Core.Contracts.AppServifces
{
    public interface ICategoryAppServices
    {
        Task<List<CategoryMenuDto>> GetCategoriesForMenu(CancellationToken cancellationToken);
        Task<List<CategoryWithCountDto>> GetCategoriesWithCount(CancellationToken cancellationToken);

    }
}
