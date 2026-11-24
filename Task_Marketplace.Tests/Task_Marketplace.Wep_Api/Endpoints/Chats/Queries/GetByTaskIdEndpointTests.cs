using FluentAssertions;
using System.Net;
using Task_Marketplace.Tests.Integration.Infrastructure;
using Xunit;

namespace Task_Marketplace.Tests.Integration.Endpoints.Chats.Queries;

[Collection("DBCollection")]
public class GetByTaskIdEndpointTests(IntegrationTestFixture fixture)
{
    [Fact]
    public async Task GetChatByTaskId_WithoutAuthorization_ReturnsUnauthorized()
    {
        ChatTestHelper.ClearAuthorization(fixture.Client);

        var response = await fixture.Client.GetAsync(
            $"/api/chat/task/{Guid.NewGuid()}");

        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
    }

    [Fact]
    public async Task GetChatByTaskId_Owner_ReturnsOk()
    {
        var token = await ChatTestHelper.RegisterUserAsync(fixture.Client);
        ChatTestHelper.Authorize(fixture.Client, token);

        var taskId = await ChatTestHelper.CreateTaskAsync(fixture.Client);
        await ChatTestHelper.CreateChatAsync(fixture.Client, taskId);

        var response = await fixture.Client.GetAsync(
            $"/api/chat/task/{taskId}");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]
    public async Task GetChatByTaskId_NonExistingTask_ReturnsNotFound()
    {
        var token = await ChatTestHelper.RegisterUserAsync(fixture.Client);
        ChatTestHelper.Authorize(fixture.Client, token);

        var response = await fixture.Client.GetAsync(
            $"/api/chat/task/{Guid.NewGuid()}");

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task GetChatByTaskId_NonParticipant_ReturnsForbidden()
    {
        var token = await ChatTestHelper.RegisterUserAsync(fixture.Client);
        ChatTestHelper.Authorize(fixture.Client, token);

        var taskId = await ChatTestHelper.CreateTaskAsync(fixture.Client);

        var anotherToken = await ChatTestHelper.RegisterUserAsync(fixture.Client);
        ChatTestHelper.Authorize(fixture.Client, anotherToken);

        var response = await fixture.Client.GetAsync(
            $"/api/chat/task/{taskId}");

        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
    }

    [Fact]
    public async Task GetChatByTaskId_ChatDoesNotExist_ReturnsNotFound()
    {
        var token = await ChatTestHelper.RegisterUserAsync(fixture.Client);
        ChatTestHelper.Authorize(fixture.Client, token);

        var taskId = await ChatTestHelper.CreateTaskAsync(fixture.Client);

        var response = await fixture.Client.GetAsync(
            $"/api/chat/task/{taskId}");

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }
}