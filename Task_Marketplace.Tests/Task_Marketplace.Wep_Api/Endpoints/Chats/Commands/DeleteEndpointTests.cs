using FluentAssertions;
using Shared.Enums;
using System.Net;
using Task_Marketplace.Tests.Integration.Infrastructure;
using Xunit;

namespace Task_Marketplace.Tests.Integration.Endpoints.Chats.Commands;

[Collection("DBCollection")]
public class DeleteEndpointTests(IntegrationTestFixture fixture)
{
    [Fact]
    public async Task DeleteChat_WithoutAuthorization_ReturnsUnauthorized()
    {
        ChatTestHelper.ClearAuthorization(fixture.Client);

        var response = await fixture.Client.DeleteAsync(
            $"/api/chat/{Guid.NewGuid()}");

        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
    }

    [Fact]
    public async Task DeleteChat_Owner_ReturnsNoContent()
    {
        var token = await ChatTestHelper.RegisterUserAsync(fixture.Client);
        ChatTestHelper.Authorize(fixture.Client, token);

        var taskId = await ChatTestHelper.CreateTaskAsync(fixture.Client);
        var chat = await ChatTestHelper.CreateChatAsync(fixture.Client, taskId);

        var response = await fixture.Client.DeleteAsync(
            $"/api/chat/{chat.Id}");

        response.StatusCode.Should().Be(HttpStatusCode.NoContent);
    }

    [Fact]
    public async Task DeleteChat_NonExistingChat_ReturnsNotFound()
    {
        var token = await ChatTestHelper.RegisterUserAsync(fixture.Client);
        ChatTestHelper.Authorize(fixture.Client, token);

        var response = await fixture.Client.DeleteAsync(
            $"/api/chat/{Guid.NewGuid()}");

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task DeleteChat_NonOwner_ReturnsForbidden()
    {
        var token = await ChatTestHelper.RegisterUserAsync(fixture.Client);
        ChatTestHelper.Authorize(fixture.Client, token);

        var taskId = await ChatTestHelper.CreateTaskAsync(fixture.Client);
        var chat = await ChatTestHelper.CreateChatAsync(fixture.Client, taskId);

        var anotherToken = await ChatTestHelper.RegisterUserAsync(fixture.Client);
        ChatTestHelper.Authorize(fixture.Client, anotherToken);

        var response = await fixture.Client.DeleteAsync(
            $"/api/chat/{chat.Id}");

        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
    }

    [Fact]
    public async Task DeleteChat_ExecutorRole_ReturnsForbidden()
    {
        var token = await ChatTestHelper.RegisterUserAsync(
            fixture.Client,
            UserRole.Executor);

        ChatTestHelper.Authorize(fixture.Client, token);

        var response = await fixture.Client.DeleteAsync(
            $"/api/chat/{Guid.NewGuid()}");

        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
    }
}