namespace Task_Marketplace.Application.Interfaces.Cache;

public interface ICacheQuery
{
    public string CacheKey { get; }
    public TimeSpan? Ttl { get; }
}
