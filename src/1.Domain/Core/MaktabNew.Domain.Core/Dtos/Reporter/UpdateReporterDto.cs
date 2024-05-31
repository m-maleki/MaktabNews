namespace MaktabNews.Domain.Core.Dtos.Reporter;
public class UpdateReporterDto
{
    public int AppUserId { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
    public string AboutMe { get; set; }
    public string? ImageAddress { get; set; }
    public List<int>? Categories { get; set; }
}