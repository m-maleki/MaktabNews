using MaktabNew.Domain.Core.Entities;
using MaktabNews.Domain.Core.Dtos.News;

namespace MaktabNews.Domain.Core.Contracts.Repository
{
    public interface INewsRepository
    {
        public List<NewsSummeryDto> GetAll();
        public NewsDetailsDto GetDetails(int id);
        public List<NewsRecentDto> GetRecent(int count);
    }
}
