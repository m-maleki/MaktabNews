using MaktabNews.Domain.Core.Dtos.Comment;

namespace MaktabNews.Domain.Core.Contracts.AppServices;
public interface ICommentAppServices
{
    Task<List<CommentViewDto>> GetComments(int id, CancellationToken cancellationToken);
    Task Create(CreateCommentDto model, CancellationToken cancellationToken);
}