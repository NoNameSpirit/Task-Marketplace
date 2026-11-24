using FluentAssertions;
using System.Net;
using System.Net.Http.Json;
using Task_Marketplace.Shared.Dtos.Requests.Chats.Commands;
using Task_Marketplace.Tests.Integration.Infrastructure;
using Xunit;

namespace Task_Marketplace.Tests.Integration.Endpoints.Chats.Commands;

[Collection("DBCollection")]
public class AddMessageEndpointTests(IntegrationTestFixture fixture)
{
    [Fact]
    public async Task AddMessage_WithoutAuthorization_ReturnsUnauthorized()
    {
        ChatTestHelper.ClearAuthorization(fixture.Client);

        var response = await fixture.Client.PostAsJsonAsync(
            $"/api/chat/{Guid.NewGuid()}/messages",
            new AddMessageRequest(Guid.NewGuid(), "Hello"));

        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
    }

    [Fact]
    public async Task AddMessage_ValidData_ReturnsNoContent()
    {
        var token = await ChatTestHelper.RegisterUserAsync(fixture.Client);
        ChatTestHelper.Authorize(fixture.Client, token);

        var taskId = await ChatTestHelper.CreateTaskAsync(fixture.Client);
        var chat = await ChatTestHelper.CreateChatAsync(fixture.Client, taskId);

        var response = await fixture.Client.PostAsJsonAsync(
            $"/api/chat/{chat.Id}/messages",
            new AddMessageRequest(chat.Id, "Hello"));

        response.StatusCode.Should().Be(HttpStatusCode.NoContent);
    }

    [Fact]
    public async Task AddMessage_NonExistingChat_ReturnsNotFound()
    {
        var token = await ChatTestHelper.RegisterUserAsync(fixture.Client);
        ChatTestHelper.Authorize(fixture.Client, token);

        var chatId = Guid.NewGuid();

        var response = await fixture.Client.PostAsJsonAsync(
            $"/api/chat/{chatId}/messages",
            new AddMessageRequest(chatId, "Hello"));

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task AddMessage_NonParticipant_ReturnsForbidden()
    {
        var token = await ChatTestHelper.RegisterUserAsync(fixture.Client);
        ChatTestHelper.Authorize(fixture.Client, token);

        var taskId = await ChatTestHelper.CreateTaskAsync(fixture.Client);
        var chat = await ChatTestHelper.CreateChatAsync(fixture.Client, taskId);

        var anotherToken = await ChatTestHelper.RegisterUserAsync(fixture.Client);
        ChatTestHelper.Authorize(fixture.Client, anotherToken);

        var response = await fixture.Client.PostAsJsonAsync(
            $"/api/chat/{chat.Id}/messages",
            new AddMessageRequest(chat.Id, "Hello"));

        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
    }

    [Fact]
    public async Task AddMessage_EmptyText_ReturnsBadRequest()
    {
        var token = await ChatTestHelper.RegisterUserAsync(fixture.Client);
        ChatTestHelper.Authorize(fixture.Client, token);

        var taskId = await ChatTestHelper.CreateTaskAsync(fixture.Client);
        var chat = await ChatTestHelper.CreateChatAsync(fixture.Client, taskId);

        var response = await fixture.Client.PostAsJsonAsync(
            $"/api/chat/{chat.Id}/messages",
            new AddMessageRequest(chat.Id, string.Empty));

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }
}