using MaktabNews.Domain.Core.Dtos.News;

namespace MaktabNews.Domain.Core.Contracts.Repository
{
    public interface INewsRepository
    {
        Task<List<NewsSummeryDto>> GetAll(CancellationToken cancellationToken);
        Task<NewsDetailsDto> GetDetails(int id, CancellationToken cancellationToken);
        Task<List<NewsRecentDto>> GetRecent(int count, CancellationToken cancellationToken);
    }
}
