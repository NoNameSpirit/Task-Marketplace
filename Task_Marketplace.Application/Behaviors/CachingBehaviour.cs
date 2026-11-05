using MediatR;
using Shared.Dtos.Responses;
using Task_Marketplace.Application.Abstraction.Cache;

namespace Task_Marketplace.Application.Behaviors;

public class CachingBehaviour<TRequest, TResponse>
    : IPipelineBehavior<TRequest, TResponse>
    where TRequest : notnull
{
    private readonly ICacheService _cache;

    public CachingBehaviour(ICacheService cache)
    {
        _cache = cache;
    }

    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
    {
        if (request is not ICacheQuery cacheQuery)
        {
            return await next(cancellationToken);
        }

        var cached = await _cache.GetAsync<TResponse>(
            cacheQuery.CacheKey,
            cancellationToken);

        if (cached is not null)
        {
            return cached;
        }

        var response = await next(cancellationToken);

        if (response is not IResult { IsSuccess: false })
        {
            await _cache.SetAsync(
                cacheQuery.CacheKey,
                response,
                cacheQuery.Ttl,
                cancellationToken);
        }

        return response;
    }
}
