
namespace MaktabNews.Domain.Core.Entities;
public class Comment
{
    public int Id { get; set; }
    public string Description { get; set; }
    public bool IsActive { get; set; } = false;
    public ApplicationUser User { get; set; }
    public News News { get; set; }
    public int NewsId { get; set; }
    public int UserId { get; set; }
    public DateTime CreateAt { get; set; }

}