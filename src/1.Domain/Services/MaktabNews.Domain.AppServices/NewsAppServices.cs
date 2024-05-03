using MaktabNews.Domain.Core.Contracts.AppServifces;
using MaktabNews.Domain.Core.Contracts.Services;
using MaktabNews.Domain.Core.Dtos.News;
using MaktabNews.Domain.Core.Entities.Configs;

namespace MaktabNews.Domain.AppServices
{
    public class NewsAppServices : INewsAppServices
    {
        private readonly INewsServices _newsServices;
        private readonly SiteSettings _siteSettings;

        public NewsAppServices(INewsServices newsServices,
            SiteSettings siteSettings)
        {
            _newsServices = newsServices;
            _siteSettings = siteSettings;
        }

        public async Task<List<NewsSummeryDto>> GetAll(CancellationToken cancellationToken)
        {
            return await _newsServices.GetAll(cancellationToken);
        }

        public async Task<NewsDetailsDto> GetDetails(int id,CancellationToken cancellationToken)
        {
            return await _newsServices.GetDetails(id, cancellationToken);
        }

        public async Task<List<NewsRecentDto>> GetRecent(CancellationToken cancellationToken)
        {
            var recentCount = _siteSettings.NewsConfiguration.RecentCount;
            return await _newsServices.GetRecent(recentCount, cancellationToken);
        }
    }
}
