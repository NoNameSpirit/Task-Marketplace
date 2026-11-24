using FluentAssertions;
using System.Net;
using Task_Marketplace.Tests.Integration.Infrastructure;
using Xunit;

namespace Task_Marketplace.Tests.Integration.Endpoints.Chats.Queries;

[Collection("DBCollection")]
public class GetByIdEndpointTests(IntegrationTestFixture fixture)
{
    [Fact]
    public async Task GetChat_WithoutAuthorization_ReturnsUnauthorized()
    {
        ChatTestHelper.ClearAuthorization(fixture.Client);

        var response = await fixture.Client.GetAsync(
            $"/api/chat/{Guid.NewGuid()}");

        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
    }

    [Fact]
    public async Task GetChat_ExistingChat_ReturnsOk()
    {
        var token = await ChatTestHelper.RegisterUserAsync(fixture.Client);
        ChatTestHelper.Authorize(fixture.Client, token);

        var taskId = await ChatTestHelper.CreateTaskAsync(fixture.Client);
        var chat = await ChatTestHelper.CreateChatAsync(fixture.Client, taskId);

        var response = await fixture.Client.GetAsync(
            $"/api/chat/{chat.Id}");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]
    public async Task GetChat_NonExistingChat_ReturnsNotFound()
    {
        var token = await ChatTestHelper.RegisterUserAsync(fixture.Client);
        ChatTestHelper.Authorize(fixture.Client, token);

        var response = await fixture.Client.GetAsync(
            $"/api/chat/{Guid.NewGuid()}");

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }
}