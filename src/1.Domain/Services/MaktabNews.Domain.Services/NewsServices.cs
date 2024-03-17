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

        public List<NewsSummeryDto> GetAll()
        {
            return _newsRepository.GetAll();
        }

        public NewsDetailsDto GetDetails(int id)
        {
            return _newsRepository.GetDetails(id);
        }

        public List<NewsRecentDto> GetRecent(int count)
        {
            return _newsRepository.GetRecent(count);
        }
    }
}
