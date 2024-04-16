using System.Text.Json;
using Microsoft.Extensions.Caching.Distributed;

namespace MaktabNews.Redis;
public class RedisCacheServices : IRedisCacheServices
{
    private readonly IDistributedCache _distributedCache;

    public RedisCacheServices(IDistributedCache distributedCache)
    {
        _distributedCache = distributedCache;
    }

    public void Set<T>(string key, T value, int expireTime)
    {
        var cacheOption = new DistributedCacheEntryOptions()
        {
                AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(expireTime)
        };

        _distributedCache.SetString(key,JsonSerializer.Serialize(value), cacheOption);
    }

    public void SetSliding<T>(string key, T value, int expireTime)
    {
        var cacheOption = new DistributedCacheEntryOptions()
        {
            SlidingExpiration = TimeSpan.FromMinutes(expireTime)
        };

        _distributedCache.SetString(key, JsonSerializer.Serialize(value), cacheOption);
    }

    public T Get<T>(string key)
    {
        var value = _distributedCache.GetString(key);

        if (value != null)
        {
            return JsonSerializer.Deserialize<T>(value);
        }

        return default;
    }
}