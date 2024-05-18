namespace MaktabNews.Domain.Core.Entities;

public abstract class User
{
    public int Id { get; set; }
    public string? AboutMe { get; set; }
    public string? FullName { get; set; }
    public string? Address { get; set; }
    public string? ImageAddress { get; set; }
}
