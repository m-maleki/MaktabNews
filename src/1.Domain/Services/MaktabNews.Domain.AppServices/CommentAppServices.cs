using MaktabNews.Domain.Core.Contracts.AppServices;
using MaktabNews.Domain.Core.Contracts.Services;
using MaktabNews.Domain.Core.Dtos.Comment;

namespace MaktabNews.Domain.AppServices;
public class CommentAppServices : ICommentAppServices
{
    private readonly ICommentServices _commentServices;

    public CommentAppServices(ICommentServices commentServices)
    {
        _commentServices = commentServices;
    }

    public Task<List<CommentViewDto>> GetComments(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task Create(CreateCommentDto model, CancellationToken cancellationToken)
    {
        await _commentServices.Create(model, cancellationToken);
    }
}