namespace MaktabNews.Domain.Core.Entities.Configs;
public class RedisConfiguration
{
    public string ConnectionString { get; set; }
    public string Password { get; set; }
    public int DefaultDatabase { get; set; }
}