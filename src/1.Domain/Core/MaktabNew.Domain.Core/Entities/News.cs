
namespace MaktabNews.Domain.Core.Entities;
public class News
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string ShortDescription { get; set; }
    public string Description { get; set; }
    public string? ImageAddress { get; set; }
    public DateTime CreateAt { get; set; }
    public int CategoryId { get; set; }
    public bool IsActive { get; set; } = false;
    public int VisitCount { get; set; }
    public Category Category { get; set; }
    public Reporter Reporter { get; set; }
    public int ReporterId { get; set; }
    public List<Tag> Tags { get; set; } = new List<Tag>();
    public List<Comment> Comments { get; set; } = new List<Comment>();
}