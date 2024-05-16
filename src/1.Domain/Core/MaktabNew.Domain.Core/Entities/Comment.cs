namespace MaktabNew.Domain.Core.Entities;
public class Comment
{
    public int Id { get; set; }
    public string Description { get; set; }
    public bool IsActive { get; set; } = false;
    public ApplicationUser User { get; set; }
    public DateTime CreateAt { get; set; }
}