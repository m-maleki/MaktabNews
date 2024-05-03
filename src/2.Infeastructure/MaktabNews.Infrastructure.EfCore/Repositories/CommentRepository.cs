using MaktabNews.Domain.Core.Contracts.Repository;
using MaktabNews.Domain.Core.Dtos.Comment;

namespace MaktabNews.Infrastructure.EfCore.Repositories
{
    public class CommentRepository :ICommentRepository

    {
        public async Task<List<CommentViewDto>> GetComments(int id,CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
