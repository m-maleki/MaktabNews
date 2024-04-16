using MaktabNews.Domain.Core.Contracts.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaktabNews.Domain.Core.Dtos.Category;
using MaktabNews.Infrastructure.EfCore.Common;
using MaktabNews.Redis;

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

        public List<CategoryMenuDto> GetCategoriesForMenu()
        {
            var result = _redisCacheServices.Get<List<CategoryMenuDto>>("CategoriesForMenu");

            if (result == null)
            {
                result = _appDbContext.Categories
                    .Select(c => new CategoryMenuDto
                    {
                        Id = c.Id,
                        Title = c.Title,
                    }).ToList();

                _redisCacheServices.SetSliding("CategoriesForMenu",result,120);
            }

            return result;
        }

        public List<CategoryWithCountDto> GetCategoriesWithCount()
        {
            var result = _appDbContext.Categories
                .Select(x => new CategoryWithCountDto
                {
                    Id = x.Id,
                    Title = x.Title,
                    NewsCount = x.NewsList.Count
                }).ToList();

            return result;
        }
    }
}
