using MaktabNews.Domain.Core.Contracts.Repository;
using MaktabNews.Domain.Core.Dtos.Tag;
using MaktabNews.Infrastructure.EfCore.Common;

namespace MaktabNews.Infrastructure.EfCore.Repositories
{
    public class TagRepository : ITagRepository
    {
        private readonly AppDbContext _appDbContext;

        public TagRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<TagViewDto> GetAll()
        {
            var result = _appDbContext.Tages
                .Select(x => new TagViewDto
                {
                    Id = x.Id,
                    Title = x.Title,
                }).ToList();

            return result;
        }
    }
}
