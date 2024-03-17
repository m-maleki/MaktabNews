namespace MaktabNews.Domain.Core.Dtos.Category
{
    public class CategoryWithCountDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int NewsCount { get; set; }
    }
}
