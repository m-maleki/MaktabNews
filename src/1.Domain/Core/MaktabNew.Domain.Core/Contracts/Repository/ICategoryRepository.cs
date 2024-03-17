using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaktabNews.Domain.Core.Dtos.Category;

namespace MaktabNews.Domain.Core.Contracts.Repository
{
    public interface ICategoryRepository
    {
        public List<CategoryMenuDto> GetCategoriesForMenu();
        public List<CategoryWithCountDto> GetCategoriesWithCount();
    }
}
