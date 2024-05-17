using MaktabNews.Domain.Core.Contracts.Repository;
using MaktabNews.Domain.Core.Contracts.Services;
using MaktabNews.Domain.Core.Dtos.Comment;

namespace MaktabNews.Domain.Services;
public class CommentServices : ICommentServices
{
    private readonly ICommentRepository _commentRepository;

    public CommentServices(ICommentRepository commentRepository)
    {
        _commentRepository = commentRepository;
    }

    public Task<List<CommentViewDto>> GetComments(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task Create(CreateCommentDto model, CancellationToken cancellationToken)
    {
        await _commentRepository.Create(model, cancellationToken);
    }
}