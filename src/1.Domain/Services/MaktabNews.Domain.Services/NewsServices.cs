using MaktabNews.Domain.Core.Contracts.Repository;
using MaktabNews.Domain.Core.Contracts.Services;
using MaktabNews.Domain.Core.Dtos.News;

namespace MaktabNews.Domain.Services
{
    public class NewsServices : INewsServices
    {
        private readonly INewsRepository _newsRepository;

        public NewsServices(INewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public async Task<List<NewsSummeryDto>> GetAll(CancellationToken cancellationToken)
        {
            return await _newsRepository.GetAll(cancellationToken);
        }

        public async Task<NewsDetailsDto> GetDetails(int id,CancellationToken cancellationToken)
        {
            return await _newsRepository.GetDetails(id, cancellationToken);
        }

        public async Task<List<NewsRecentDto>> GetRecent(int count, CancellationToken cancellationToken)
        {
            return await _newsRepository.GetRecent(count, cancellationToken);
        }
    }
}
