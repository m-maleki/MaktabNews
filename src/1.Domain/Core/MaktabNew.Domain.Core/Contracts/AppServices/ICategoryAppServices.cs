using MaktabNews.Domain.Core.Dtos.Category;

namespace MaktabNews.Domain.Core.Contracts.AppServifces
{
    public interface ICategoryAppServices
    {
        public List<CategoryMenuDto> GetCategoriesForMenu();
        public List<CategoryWithCountDto> GetCategoriesWithCount();

    }
}
