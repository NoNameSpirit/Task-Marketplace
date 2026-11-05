namespace Task_Marketplace.Application.Abstraction.Cache;

public interface ICacheQuery
{
    public string CacheKey { get; }
    public TimeSpan? Ttl { get; }
}
