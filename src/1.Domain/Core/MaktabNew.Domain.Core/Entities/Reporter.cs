namespace MaktabNew.Domain.Core.Entities;

public class Reporter
{
    public int Id { get; set; }
    public List<News> NewsList { get; set; }
    public string? AboutMe { get; set; }
    public string FullName { get; set; }
    public string? ImageAddress { get; set; }
}