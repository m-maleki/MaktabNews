using MaktabNews.Domain.Core.Dtos.Comment;

namespace MaktabNews.Domain.Core.Contracts.Repository
{
    public interface ICommentRepository
    {
        Task<List<CommentViewDto>> GetComments(int id, CancellationToken cancellationToken);
    }
}
