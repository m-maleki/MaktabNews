namespace MaktabNews.Domain.Core.Dtos.Comment;
public class CreateCommentDto
{
    public string Description { get; set; }
    public int UserId { get; set; }
    public int NewsId { get; set; }

}
