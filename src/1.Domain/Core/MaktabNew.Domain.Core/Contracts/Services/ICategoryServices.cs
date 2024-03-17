using MaktabNews.Domain.Core.Dtos.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabNews.Domain.Core.Contracts.Services
{
    public interface ICategoryServices
    {
        public List<CategoryMenuDto> GetCategoriesForMenu();
        public List<CategoryWithCountDto> GetCategoriesWithCount();

    }
}
