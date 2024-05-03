using MaktabNews.Domain.Core.Contracts.Repository;
using MaktabNews.Domain.Core.Dtos.Tag;
using MaktabNews.Infrastructure.EfCore.Common;
using Microsoft.EntityFrameworkCore;

namespace MaktabNews.Infrastructure.EfCore.Repositories
{
    public class TagRepository : ITagRepository
    {
        private readonly AppDbContext _appDbContext;

        public TagRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<TagViewDto>> GetAll(CancellationToken cancellationToken)
        {
            var result = await _appDbContext.Tages
                .Select(x => new TagViewDto
                {
                    Id = x.Id,
                    Title = x.Title,
                }).ToListAsync(cancellationToken);

            return result;
        }
    }
}
