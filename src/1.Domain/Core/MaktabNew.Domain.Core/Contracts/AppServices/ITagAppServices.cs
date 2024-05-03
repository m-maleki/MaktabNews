using MaktabNews.Domain.Core.Dtos.Tag;

namespace MaktabNews.Domain.Core.Contracts.AppServifces
{
    public interface ITagAppServices
    {
        Task<List<TagViewDto>> GetAll(CancellationToken cancellationToken);
    }
}
