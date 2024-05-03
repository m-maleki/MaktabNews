namespace MaktabNews.Domain.Core.Entities.Configs;
public class SiteSettings
{
    public SqlConfiguration SqlConfiguration { get; set; }
    public RedisConfiguration RedisConfiguration { get; set; }
    public NewsConfiguration NewsConfiguration { get; set; }
    public LogConfiguration LogConfiguration { get; set; }
}