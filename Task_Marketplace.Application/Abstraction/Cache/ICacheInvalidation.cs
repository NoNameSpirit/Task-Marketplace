namespace Task_Marketplace.Application.Abstraction.Cache;

public interface ICacheInvalidation
{
    string CacheKey { get; }
}