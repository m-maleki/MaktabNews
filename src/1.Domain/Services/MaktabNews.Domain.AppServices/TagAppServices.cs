using MaktabNews.Domain.Core.Contracts.AppServifces;
using MaktabNews.Domain.Core.Contracts.Services;
using MaktabNews.Domain.Core.Dtos.Tag;

namespace MaktabNews.Domain.AppServices
{
    public class TagAppServices : ITagAppServices
    {
        private readonly ITagServices _tagServices;

        public TagAppServices(ITagServices tagServices)
        {
            _tagServices = tagServices;
        }

        public async Task<List<TagViewDto>> GetAll(CancellationToken cancellationToken)
        {
            return await _tagServices.GetAll(cancellationToken);
        }
    }
}
