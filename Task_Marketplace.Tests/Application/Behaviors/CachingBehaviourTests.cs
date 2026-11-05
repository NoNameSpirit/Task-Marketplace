using FluentAssertions;
using NSubstitute;
using Shared.Dtos.Responses;
using Task_Marketplace.Application.Behaviors;
using Task_Marketplace.Application.Interfaces.Cache;
using Xunit;

namespace Task_Marketplace.Tests.Application.Behaviors;

public class CachingBehaviourTests
{
    private readonly ICacheService _cache = Substitute.For<ICacheService>();

    private const string _cacheKey = "test-key";

    private record CacheableQuery : ICacheQuery
    {
        public string CacheKey => _cacheKey;
        public TimeSpan? Ttl => TimeSpan.FromMinutes(2);
    }

    private record RegularQuery;

    [Fact]
    public async Task Handle_CacheExists_ReturnsCachedResponse()
    {
        var expectedResponse = "Cached response";
        var behaviour = new CachingBehaviour<CacheableQuery, string>(_cache);

        _cache
            .GetAsync<string>(_cacheKey, Arg.Any<CancellationToken>())
            .Returns(expectedResponse);

        var response = await behaviour.Handle(
            new CacheableQuery(),
            _ => Task.FromResult("New response"),
            CancellationToken.None);

        response.Should().Be(expectedResponse);
    }

    [Fact]
    public async Task Handle_CacheDoesNotExist_CachesResponse()
    {
        var expectedResponse = "New response";
        var behaviour = new CachingBehaviour<CacheableQuery, string>(_cache);

        _cache
            .GetAsync<string>(_cacheKey, Arg.Any<CancellationToken>())
            .Returns(Task.FromResult<string?>(null));

        var response = await behaviour.Handle(
            new CacheableQuery(),
            _ => Task.FromResult(expectedResponse),
            CancellationToken.None);

        response.Should().Be(expectedResponse);
        await _cache.Received(1).SetAsync(
            _cacheKey,
            expectedResponse,
            TimeSpan.FromMinutes(2),
            Arg.Any<CancellationToken>());
    }

    [Fact]
    public async Task Handle_ResponseIsFailure_DoesNotCacheResponse()
    {
        var expectedResponse = Result.Failure("Error");
        var behaviour = new CachingBehaviour<CacheableQuery, Result>(_cache);

        var response = await behaviour.Handle(
            new CacheableQuery(),
            _ => Task.FromResult(expectedResponse),
            CancellationToken.None);

        response.Should().Be(expectedResponse);
        await _cache.DidNotReceive().SetAsync(
            Arg.Any<string>(),
            Arg.Any<Result>(),
            Arg.Any<TimeSpan?>(),
            Arg.Any<CancellationToken>());
    }

    [Fact]
    public async Task Handle_RequestDoesNotImplementICacheQuery_DoesNotUseCache()
    {
        var expectedResponse = "Response";
        var behaviour = new CachingBehaviour<RegularQuery, string>(_cache);

        var response = await behaviour.Handle(
            new RegularQuery(),
            _ => Task.FromResult(expectedResponse),
            CancellationToken.None);

        response.Should().Be(expectedResponse);
        await _cache.DidNotReceive().GetAsync<string>(
            Arg.Any<string>(),
            Arg.Any<CancellationToken>());
    }
}