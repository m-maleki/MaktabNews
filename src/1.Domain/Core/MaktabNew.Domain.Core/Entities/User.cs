using MaktabNew.Domain.Core.Enum;

namespace MaktabNew.Domain.Core.Entities;
public abstract class User
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string FullName { get; set; }
    public string? ImageAddress { get; set; }
    public UserRole UserRole { get; set; }
    public List<Comment> Comments { get; set; }
}