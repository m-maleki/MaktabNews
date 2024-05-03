using MaktabNews.Domain.Core.Contracts.Repository;
using MaktabNews.Domain.Core.Contracts.Services;
using MaktabNews.Domain.Core.Dtos.Tag;

namespace MaktabNews.Domain.Services
{
    public class TagServices : ITagServices
    {
        private readonly ITagRepository _tagRepository;

        public TagServices(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public async Task<List<TagViewDto>> GetAll(CancellationToken cancellationToken)
        {
           return await _tagRepository.GetAll(cancellationToken);
        }
    }
}
