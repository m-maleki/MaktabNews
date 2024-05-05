using MaktabNews.Domain.Core.Dtos.Category;

namespace MaktabNews.Domain.Core.Contracts.Repository
{
    public interface ICategoryRepository
    {
        Task Create(string title, CancellationToken cancellationToken);
        Task<List<CategoryMenuDto>> GetCategoriesForMenu(CancellationToken cancellationToken);
        Task<List<CategoryWithCountDto>> GetCategoriesWithCount(CancellationToken cancellationToken);
        Task Delete(int id, CancellationToken cancellationToken);
        Task<string> GetById(int id, CancellationToken cancellationToken);
        Task Update(int id, string title, CancellationToken cancellationToken);
    }
}
