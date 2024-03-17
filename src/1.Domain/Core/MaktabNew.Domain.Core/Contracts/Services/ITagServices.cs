using MaktabNews.Domain.Core.Dtos.Tag;

namespace MaktabNews.Domain.Core.Contracts.Services
{
    public interface ITagServices
    {
        public List<TagViewDto> GetAll();
    }
}
