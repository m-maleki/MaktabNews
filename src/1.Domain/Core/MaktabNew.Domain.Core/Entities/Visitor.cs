namespace MaktabNews.Domain.Core.Entities;

public class Visitor : User
{
   public List<Comment> Comments { get; set; }
}