using MaktabNews.Domain.Core.Dtos.News;

namespace MaktabNews.Domain.Core.Contracts.AppServifces
{
    public interface INewsAppServices
    {
        public List<NewsSummeryDto> GetAll();
        public NewsDetailsDto GetDetails(int id);
        public List<NewsRecentDto> GetRecent(int count);
    }
}
