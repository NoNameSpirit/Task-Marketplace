using FluentAssertions;
using Shared.Dtos.Responses.Chats;
using System.Net;
using System.Net.Http.Json;
using Task_Marketplace.Shared.Dtos.Requests.Chats.Commands;
using Task_Marketplace.Tests.Integration.Infrastructure;
using Xunit;

namespace Task_Marketplace.Tests.Integration.Endpoints.Chats.Queries;

[Collection("DBCollection")]
public class GetAllEndpointTests(IntegrationTestFixture fixture)
{
    [Fact]
    public async Task GetMessages_WithoutAuthorization_ReturnsUnauthorized()
    {
        ChatTestHelper.ClearAuthorization(fixture.Client);

        var response = await fixture.Client.GetAsync(
            $"/api/chat/{Guid.NewGuid()}/messages");

        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
    }

    [Fact]
    public async Task GetMessages_ExistingChat_ReturnsOk()
    {
        var token = await ChatTestHelper.RegisterUserAsync(fixture.Client);
        ChatTestHelper.Authorize(fixture.Client, token);

        var taskId = await ChatTestHelper.CreateTaskAsync(fixture.Client);
        var chat = await ChatTestHelper.CreateChatAsync(fixture.Client, taskId);

        var response = await fixture.Client.GetAsync(
            $"/api/chat/{chat.Id}/messages");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]
    public async Task GetMessages_ChatWithMessages_ReturnsMessages()
    {
        var token = await ChatTestHelper.RegisterUserAsync(fixture.Client);
        ChatTestHelper.Authorize(fixture.Client, token);

        var taskId = await ChatTestHelper.CreateTaskAsync(fixture.Client);
        var chat = await ChatTestHelper.CreateChatAsync(fixture.Client, taskId);

        await fixture.Client.PostAsJsonAsync(
            $"/api/chat/{chat.Id}/messages",
            new AddMessageRequest(chat.Id, "Hello"));

        var response = await fixture.Client.GetAsync(
            $"/api/chat/{chat.Id}/messages");

        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var result = await response.Content.ReadFromJsonAsync<ChatDto>();

        result!.Messages.Should().ContainSingle();
        result.Messages[0].Text.Should().Be("Hello");
    }

    [Fact]
    public async Task GetMessages_NonExistingChat_ReturnsNotFound()
    {
        var token = await ChatTestHelper.RegisterUserAsync(fixture.Client);
        ChatTestHelper.Authorize(fixture.Client, token);

        var response = await fixture.Client.GetAsync(
            $"/api/chat/{Guid.NewGuid()}/messages");

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }
}