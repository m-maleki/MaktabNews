using MaktabNews.Domain.Core.Dtos.Tag;

namespace MaktabNews.Domain.Core.Contracts.Repository
{
    public interface ITagRepository
    {
        Task<List<TagViewDto>> GetAll(CancellationToken cancellationToken);
    }
}
