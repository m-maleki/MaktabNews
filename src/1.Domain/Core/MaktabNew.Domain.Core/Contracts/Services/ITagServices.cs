using MaktabNews.Domain.Core.Dtos.Tag;

namespace MaktabNews.Domain.Core.Contracts.Services
{
    public interface ITagServices
    {
        Task<List<TagViewDto>> GetAll(CancellationToken cancellationToken);
    }
}
