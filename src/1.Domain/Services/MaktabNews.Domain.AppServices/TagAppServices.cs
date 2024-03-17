using MaktabNews.Domain.Core.Contracts.AppServifces;
using MaktabNews.Domain.Core.Contracts.Services;
using MaktabNews.Domain.Core.Dtos.Tag;

namespace MaktabNews.Domain.AppServices
{
    public class TagAppServices : ITagAppServices
    {
        private readonly ITagServices _tagServices;

        public TagAppServices(ITagServices tagServices)
        {
            _tagServices = tagServices;
        }

        public List<TagViewDto> GetAll()
        {
            return _tagServices.GetAll();
        }
    }
}
