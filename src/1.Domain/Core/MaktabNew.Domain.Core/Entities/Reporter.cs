namespace MaktabNew.Domain.Core.Entities;

public class Reporter : User
{
    public List<News> NewsList { get; set; }
    public string? AboutMe { get; set; }
}