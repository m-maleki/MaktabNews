using MaktabNews.Domain.Core.Dtos.Tag;

namespace MaktabNews.Domain.Core.Contracts.Repository
{
    public interface ITagRepository
    {
        public List<TagViewDto> GetAll();
    }
}
