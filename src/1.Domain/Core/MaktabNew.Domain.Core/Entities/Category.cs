namespace MaktabNew.Domain.Core.Entities;

public class Category
{
    public int Id { get; set; }
    public string Title { get; set; }
    public List<News> NewsList { get; set; } = new List<News>();
}