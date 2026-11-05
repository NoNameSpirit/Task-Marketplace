using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;
using Task_Marketplace.Application.Abstraction.Cache;

namespace Infrastructure.Cache;

public class CacheService : ICacheService
{
    private readonly IDistributedCache _cache;

    public CacheService(IDistributedCache cache)
    {
        _cache = cache;
    }

    public async Task<T?> GetAsync<T>(string key, CancellationToken cancellationToken = default)
    {
        var cached = await _cache.GetStringAsync(key, cancellationToken);

        if (cached is null)
        {
            return default;
        }

        return JsonSerializer.Deserialize<T>(cached);
    }

    public async Task RemoveAsync(string key, CancellationToken cancellationToken = default)
    {
        await _cache.RemoveAsync(key, cancellationToken);
    }

    public async Task SetAsync<T>(string key, T? value, TimeSpan? ttl = null, CancellationToken cancellationToken = default)
    {
        var json = JsonSerializer.Serialize(value);

        if (json is null)
        {
            return;
        }

        var _options = new DistributedCacheEntryOptions()
        {
            AbsoluteExpirationRelativeToNow = ttl ?? TimeSpan.FromMinutes(5)
        };

        await _cache.SetStringAsync(key, json, _options, cancellationToken);
    }
}
