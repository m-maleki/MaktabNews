using MaktabNews.Redis;
using MaktabNews.Domain.Core.Dtos.Category;
using MaktabNews.Infrastructure.EfCore.Common;
using MaktabNews.Domain.Core.Contracts.Repository;
using MaktabNews.Domain.Core.Entities;
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

        public async Task Create(string title, CancellationToken cancellationToken)
        {
            var entity = new Category()
            {
                Title = title
            };

            await _appDbContext.Categories.AddAsync(entity, cancellationToken);
            await _appDbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<CategoryMenuDto>> GetCategoriesForMenu(CancellationToken cancellationToken)
        {
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

        public async Task Delete(int id, CancellationToken cancellationToken)
        {
            var entity = await _appDbContext.Categories
                .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

            if (entity != null)
            {
                _appDbContext.Categories.Remove(entity);
                await _appDbContext.SaveChangesAsync(cancellationToken);
            }
            else
            {
                throw new Exception($"Category with id {id} not found");
            }
        }

        public async Task<string> GetById(int id, CancellationToken cancellationToken)
        {

            var entity = await _appDbContext.Categories
                .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

            if (entity != null)
            {
                return entity.Title;
            }
            else
            {
                throw new Exception($"Category with id {id} not found");
            }
        }

        public async Task Update(int id, string title, CancellationToken cancellationToken)
        {
            var entity = await _appDbContext.Categories
                .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

            if (entity != null)
            {
                 entity.Title = title;
                 await _appDbContext.SaveChangesAsync(cancellationToken);
            }
            else
            {
                throw new Exception($"Category with id {id} not found");
            }
        }
    }
}
