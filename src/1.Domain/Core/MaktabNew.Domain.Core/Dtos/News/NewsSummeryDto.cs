namespace MaktabNews.Domain.Core.Dtos.News
{
    public class NewsSummeryDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string CategoryName { get; set; }
        public string ReporterName { get; set; }
        public DateTime CreateAt { get; set; }
        public string NewsImageAddress { get; set; }
        public string ReporterImageAddress { get; set; }
    }
}
