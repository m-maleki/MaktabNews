using System.Security.AccessControl;

namespace MaktabNews.Domain.Core.Dtos.Reporter
{
    public class ReporterSummeryDto
    {
        public int Id { get; set; }
        public string AboutMe { get; set; }
        public string ImageAddress { get; set; }
        public string FullName { get; set; }
        public string? Address { get; set; }
        public List<int>? CategoryIds { get; set; }
    }
}
