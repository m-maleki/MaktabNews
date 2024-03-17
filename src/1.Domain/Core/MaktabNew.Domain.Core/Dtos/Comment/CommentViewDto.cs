namespace MaktabNews.Domain.Core.Dtos.Comment
{
    public class CommentViewDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string VisitorName { get; set; }
        public string VisitorImageAddress { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
