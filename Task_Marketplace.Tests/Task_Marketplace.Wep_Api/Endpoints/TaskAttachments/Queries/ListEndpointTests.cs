using FluentAssertions;
using Shared.Dtos.Responses.ProjectTasks;
using System.Net;
using System.Net.Http.Json;
using Task_Marketplace.Tests.Integration.Infrastructure;
using Xunit;

namespace Task_Marketplace.Tests.Integration.Endpoints.TaskAttachments.Queries;

[Collection("DBCollection")]
public class ListEndpointTests(IntegrationTestFixture fixture)
{
    [Fact]
    public async Task List_WithoutAuthorization_ReturnsUnauthorized()
    {
        ProjectTestHelper.ClearAuthorization(fixture.Client);

        var response = await fixture.Client.GetAsync(
            $"/api/tasks/{Guid.NewGuid()}/attachments");

        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
    }

    [Fact]
    public async Task List_ExistingTaskWithoutAttachments_ReturnsEmptyList()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);
        var task = await ProjectTestHelper.CreateTaskAsync(fixture.Client);

        var response = await fixture.Client.GetAsync(
            $"/api/tasks/{task.Id}/attachments");

        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var attachments = await response.Content.ReadFromJsonAsync<List<TaskAttachmentDto>>();
        attachments.Should().BeEmpty();
    }

    [Fact]
    public async Task List_ExistingTaskWithAttachments_ReturnsAttachments()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);
        var task = await ProjectTestHelper.CreateTaskAsync(fixture.Client);

        await TaskAttachmentTestHelper.CreateAttachmentAsync(fixture.Client, task.Id);

        var response = await fixture.Client.GetAsync(
            $"/api/tasks/{task.Id}/attachments");

        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var attachments = await response.Content.ReadFromJsonAsync<List<TaskAttachmentDto>>();
        attachments.Should().ContainSingle();
    }

    [Fact]
    public async Task List_NonExistingTask_ReturnsEmptyList()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);

        var response = await fixture.Client.GetAsync(
            $"/api/tasks/{Guid.NewGuid()}/attachments");

        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var attachments = await response.Content.ReadFromJsonAsync<List<TaskAttachmentDto>>();
        attachments.Should().BeEmpty();
    }
}