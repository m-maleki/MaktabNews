namespace MaktabNews.Redis;
public interface IRedisCacheServices
{
    public void Set<T>(string key, T value, int expireTime);
    public void SetSliding<T>(string key, T value, int expireTime);
    public T Get<T>(string key);
}