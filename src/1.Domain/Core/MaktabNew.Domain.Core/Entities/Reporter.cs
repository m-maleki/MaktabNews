
using System.Security.AccessControl;

namespace MaktabNews.Domain.Core.Entities;

public class Reporter : User
{
    public List<News> NewsList { get; set; }
}