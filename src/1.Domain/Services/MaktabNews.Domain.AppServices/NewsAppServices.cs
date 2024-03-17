using MaktabNews.Domain.Core.Contracts.AppServifces;
using MaktabNews.Domain.Core.Contracts.Services;
using MaktabNews.Domain.Core.Dtos.News;

namespace MaktabNews.Domain.AppServices
{
    public class NewsAppServices : INewsAppServices
    {
        private readonly INewsServices _newsServices;

        public NewsAppServices(INewsServices newsServices)
        {
            _newsServices = newsServices;
        }

        public List<NewsSummeryDto> GetAll()
        {
            return _newsServices.GetAll();
        }

        public NewsDetailsDto GetDetails(int id)
        {
            return _newsServices.GetDetails(id);
        }

        public List<NewsRecentDto> GetRecent(int count)
        {
            return _newsServices.GetRecent(count);
        }
    }
}
