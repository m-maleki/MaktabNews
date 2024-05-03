using MaktabNews.Redis;
using MaktabNews.Domain.Core.Dtos.Category;
using MaktabNews.Infrastructure.EfCore.Common;
using MaktabNews.Domain.Core.Contracts.Repository;
using Microsoft.EntityFrameworkCore;

namespace MaktabNews.Infrastructure.EfCore.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly IRedisCacheServices _redisCacheServices;
       

        public CategoryRepository(AppDbContext appDbContext,
            IRedisCacheServices redisCacheServices)
        {
            _appDbContext = appDbContext;
            _redisCacheServices = redisCacheServices;
        }

        public async Task<List<CategoryMenuDto>> GetCategoriesForMenu(CancellationToken cancellationToken)
        {
            throw new Exception("This is test");

            var result = _redisCacheServices.Get<List<CategoryMenuDto>>("CategoriesForMenu");

            if (result == null)
            {
                result = await _appDbContext.Categories
                    .Select(c => new CategoryMenuDto
                    {
                        Id = c.Id,
                        Title = c.Title,
                    }).ToListAsync(cancellationToken);

                _redisCacheServices.SetSliding("CategoriesForMenu",result,120);
            }

            return result;
        }

        public async Task<List<CategoryWithCountDto>> GetCategoriesWithCount(CancellationToken cancellationToken)
        {
            var result = await _appDbContext.Categories
                .Select(x => new CategoryWithCountDto
                {
                    Id = x.Id,
                    Title = x.Title,
                    NewsCount = x.NewsList.Count
                }).ToListAsync(cancellationToken);

            return result;
        }
    }
}
