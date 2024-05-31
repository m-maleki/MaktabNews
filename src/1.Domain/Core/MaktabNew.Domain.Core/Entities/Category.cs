using MaktabNews.Domain.Core.Entities;

namespace MaktabNews.Domain.Core.Entities;

public class Category
{
    public int Id { get; set; }
    public string Title { get; set; }
    public List<News> NewsList { get; set; } 
    public List<Reporter>? Reporters { get; set; }
}