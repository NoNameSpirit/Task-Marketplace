using MediatR;
using Shared.Dtos.Responses;
using Task_Marketplace.Application.Abstraction.Cache;

namespace Task_Marketplace.Application.Behaviors;

public class CacheInvalidationBehaviour<TRequest, TResponse>
    : IPipelineBehavior<TRequest, TResponse>
    where TRequest : notnull
{
    private readonly ICacheService _cache;

    public CacheInvalidationBehaviour(ICacheService cache)
    {
        _cache = cache;
    }

    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
    {
        var response = await next(cancellationToken);

        if (response is IResult { IsSuccess: false })
        {
            return response;
        }

        if (request is ICacheInvalidation invalidation)
        {
            await _cache.RemoveAsync(
                invalidation.CacheKey,
                cancellationToken);
        }

        return response;
    }
}