using MaktabNews.Domain.Core.Dtos.Comment;

namespace MaktabNews.Domain.Core.Contracts.Repository
{
    public interface ICommentRepository
    {
        public List<CommentViewDto> GetComments(int id);
    }
}
