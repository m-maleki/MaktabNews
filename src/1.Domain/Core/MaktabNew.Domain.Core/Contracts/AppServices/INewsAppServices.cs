using MaktabNews.Domain.Core.Dtos.News;

namespace MaktabNews.Domain.Core.Contracts.AppServifces
{
    public interface INewsAppServices
    {
        Task<List<NewsSummeryDto>> GetAll(CancellationToken cancellationToken);
        Task<NewsDetailsDto> GetDetails(int id,CancellationToken cancellationToken);
        Task<List<NewsRecentDto>> GetRecent(CancellationToken cancellationToken);
    }
}
