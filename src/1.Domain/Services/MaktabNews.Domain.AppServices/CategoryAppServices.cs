using System.Formats.Asn1;
using MaktabNews.Domain.Core.Contracts.AppServifces;
using MaktabNews.Domain.Core.Contracts.Services;
using MaktabNews.Domain.Core.Dtos.Category;

namespace MaktabNews.Domain.AppServices
{
    public class CategoryAppServices : ICategoryAppServices
    {
        private readonly ICategoryServices _categoryServices;

        public CategoryAppServices(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        public async Task<List<CategoryMenuDto>> GetCategoriesForMenu(CancellationToken cancellationToken)
            => await _categoryServices.GetCategoriesForMenu(cancellationToken);

        public async Task<List<CategoryWithCountDto>> GetCategoriesWithCount(CancellationToken cancellationToken)
            => await _categoryServices.GetCategoriesWithCount(cancellationToken);

        public async Task Create(string title, CancellationToken cancellationToken)
            => await _categoryServices.Create(title, cancellationToken);

        public async Task Delete(int id, CancellationToken cancellationToken)
           => await _categoryServices.Delete(id, cancellationToken);

        public async Task<string> GetById(int id, CancellationToken cancellationToken)
            => await _categoryServices.GetById(id, cancellationToken);

        public async Task Update(int id, string title, CancellationToken cancellationToken)
            => await _categoryServices.Update(id, title, cancellationToken);
    }
}
