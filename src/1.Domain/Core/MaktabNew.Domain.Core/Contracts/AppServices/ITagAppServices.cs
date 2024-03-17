using MaktabNews.Domain.Core.Dtos.Tag;

namespace MaktabNews.Domain.Core.Contracts.AppServifces
{
    public interface ITagAppServices
    {
        public List<TagViewDto> GetAll();
    }
}
