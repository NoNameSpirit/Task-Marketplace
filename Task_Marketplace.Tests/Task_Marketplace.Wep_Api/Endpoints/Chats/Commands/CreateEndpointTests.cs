using FluentAssertions;
using System.Net;
using System.Net.Http.Json;
using Task_Marketplace.Shared.Dtos.Requests.Chats.Commands;
using Task_Marketplace.Tests.Integration.Infrastructure;
using Xunit;

namespace Task_Marketplace.Tests.Integration.Endpoints.Chats.Commands;

[Collection("DBCollection")]
public class CreateEndpointTests(IntegrationTestFixture fixture)
{
    [Fact]
    public async Task CreateChat_WithoutAuthorization_ReturnsUnauthorized()
    {
        ChatTestHelper.ClearAuthorization(fixture.Client);

        var response = await fixture.Client.PostAsJsonAsync(
            "/api/chat",
            new CreateChatRequest(Guid.NewGuid()));

        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
    }

    [Fact]
    public async Task CreateChat_ValidData_ReturnsCreated()
    {
        var token = await ChatTestHelper.RegisterUserAsync(fixture.Client);
        ChatTestHelper.Authorize(fixture.Client, token);

        var taskId = await ChatTestHelper.CreateTaskAsync(fixture.Client);

        var response = await fixture.Client.PostAsJsonAsync(
            "/api/chat",
            new CreateChatRequest(taskId));

        response.StatusCode.Should().Be(HttpStatusCode.Created);
    }

    [Fact]
    public async Task CreateChat_NonParticipant_ReturnsForbidden()
    {
        var token = await ChatTestHelper.RegisterUserAsync(fixture.Client);
        ChatTestHelper.Authorize(fixture.Client, token);

        var taskId = await ChatTestHelper.CreateTaskAsync(fixture.Client);

        var anotherToken = await ChatTestHelper.RegisterUserAsync(fixture.Client);
        ChatTestHelper.Authorize(fixture.Client, anotherToken);

        var response = await fixture.Client.PostAsJsonAsync(
            "/api/chat",
            new CreateChatRequest(taskId));

        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
    }

    [Fact]
    public async Task CreateChat_NonExistingTask_ReturnsForbidden()
    {
        var token = await ChatTestHelper.RegisterUserAsync(fixture.Client);
        ChatTestHelper.Authorize(fixture.Client, token);

        var response = await fixture.Client.PostAsJsonAsync(
            "/api/chat",
            new CreateChatRequest(Guid.NewGuid()));

        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
    }

    [Fact]
    public async Task CreateChat_AlreadyExists_ReturnsConflict()
    {
        var token = await ChatTestHelper.RegisterUserAsync(fixture.Client);
        ChatTestHelper.Authorize(fixture.Client, token);

        var taskId = await ChatTestHelper.CreateTaskAsync(fixture.Client);

        await ChatTestHelper.CreateChatAsync(fixture.Client, taskId);

        var response = await fixture.Client.PostAsJsonAsync(
            "/api/chat",
            new CreateChatRequest(taskId));

        response.StatusCode.Should().Be(HttpStatusCode.Conflict);
    }
}