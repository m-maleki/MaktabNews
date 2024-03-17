using MaktabNews.Domain.Core.Contracts.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaktabNews.Domain.Core.Dtos.Category;
using MaktabNews.Infrastructure.EfCore.Common;

namespace MaktabNews.Infrastructure.EfCore.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<CategoryMenuDto> GetCategoriesForMenu()
        {
            var result = _appDbContext.Categories
                .Select(c => new CategoryMenuDto
                {
                    Id = c.Id,
                    Title = c.Title,
                }).ToList();

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
