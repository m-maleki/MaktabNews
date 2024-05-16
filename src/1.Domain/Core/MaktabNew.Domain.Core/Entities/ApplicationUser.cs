using MaktabNew.Domain.Core.Enum;
using Microsoft.AspNetCore.Identity;

namespace MaktabNew.Domain.Core.Entities;
public class ApplicationUser : IdentityUser<int>
{
    public Reporter? Reporter { get; set; }
    public Visitor? Visitor { get; set; }
    public string? ImageAddress { get; set; }
    public UserRole UserRole { get; set; }
    public List<Comment> Comments { get; set; }
    public string? FullName { get; set; }
}