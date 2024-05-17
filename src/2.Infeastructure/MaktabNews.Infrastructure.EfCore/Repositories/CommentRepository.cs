using MaktabNews.Domain.Core.Contracts.Repository;
using MaktabNews.Domain.Core.Dtos.Comment;
using MaktabNews.Domain.Core.Entities;
using MaktabNews.Infrastructure.EfCore.Common;

namespace MaktabNews.Infrastructure.EfCore.Repositories
{
    public class CommentRepository :ICommentRepository
    {
        private readonly AppDbContext _appDbContext;

        public CommentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<CommentViewDto>> GetComments(int id,CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Create(CreateCommentDto model,CancellationToken cancellationToken)
        {
            var entity = new Comment()
            {
                Description = model.Description,
                UserId = model.UserId,
                IsActive = false,
                CreateAt = DateTime.Now,
                NewsId = model.NewsId,
            };

            await _appDbContext.Comments.AddAsync(entity, cancellationToken);
            await _appDbContext.SaveChangesAsync(cancellationToken);

        }
    }
}
