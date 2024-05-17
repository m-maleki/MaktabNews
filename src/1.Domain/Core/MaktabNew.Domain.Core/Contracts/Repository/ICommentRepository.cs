using MaktabNews.Domain.Core.Dtos.Comment;

namespace MaktabNews.Domain.Core.Contracts.Repository
{
    public interface ICommentRepository
    {
        Task<List<CommentViewDto>> GetComments(int id, CancellationToken cancellationToken);
        Task Create(CreateCommentDto model, CancellationToken cancellationToken);
    }
}
