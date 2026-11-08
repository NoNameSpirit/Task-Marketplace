using FluentAssertions;
using NSubstitute;
using Shared.Dtos.Responses;
using Task_Marketplace.Application.Behaviors;
using Task_Marketplace.Application.Interfaces.Cache;
using Xunit;

namespace Task_Marketplace.Tests.Application.Behaviors;

public class CacheInvalidationBehaviourTests
{
    private readonly ICacheService _cache = Substitute.For<ICacheService>();

    private const string _cacheKey = "test-key";

    private record CacheableCommand : ICacheInvalidation
    {
        public string CacheKey => _cacheKey;
    }

    private record RegularCommand;

    [Fact]
    public async Task Handle_CommandIsSuccessful_RemovesCache()
    {
        var expectedResponse = Result.Success();
        var behaviour = new CacheInvalidationBehaviour<CacheableCommand, Result>(_cache);

        var response = await behaviour.Handle(
            new CacheableCommand(),
            _ => Task.FromResult(expectedResponse),
            CancellationToken.None);

        response.Should().Be(expectedResponse);
        await _cache.Received(1).RemoveAsync(
            _cacheKey,
            Arg.Any<CancellationToken>());
    }

    [Fact]
    public async Task Handle_CommandIsFailed_DoesNotRemoveCache()
    {
        var expectedResponse = Result.Failure("Error");
        var behaviour = new CacheInvalidationBehaviour<CacheableCommand, Result>(_cache);

        var response = await behaviour.Handle(
            new CacheableCommand(),
            _ => Task.FromResult(expectedResponse),
            CancellationToken.None);

        response.Should().Be(expectedResponse);
        await _cache.DidNotReceive().RemoveAsync(
            Arg.Any<string>(),
            Arg.Any<CancellationToken>());
    }

    [Fact]
    public async Task Handle_CommandDoesNotImplementICacheInvalidation_DoesNotRemoveCache()
    {
        var expectedResponse = Result.Success();
        var behaviour = new CacheInvalidationBehaviour<RegularCommand, Result>(_cache);

        var response = await behaviour.Handle(
            new RegularCommand(),
            _ => Task.FromResult(expectedResponse),
            CancellationToken.None);

        response.Should().Be(expectedResponse);
        await _cache.DidNotReceive().RemoveAsync(
            Arg.Any<string>(),
            Arg.Any<CancellationToken>());
    }
}