using Microsoft.AspNetCore.Identity;

namespace MaktabNews.Domain.Core.Entities;
public class ApplicationUser : IdentityUser<int>
{
    public Reporter? Reporter { get; set; }
    //public int? ReporterId { get; set; }
    public Visitor? Visitor { get; set; }
    //public int? VisitorId { get; set; }
}