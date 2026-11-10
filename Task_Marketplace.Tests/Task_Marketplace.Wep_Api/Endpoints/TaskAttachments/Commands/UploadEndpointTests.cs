using FluentAssertions;
using Shared.Enums;
using System.Net;
using System.Net.Http.Json;
using Task_Marketplace.Tests.Integration.Infrastructure;
using Xunit;

namespace Task_Marketplace.Tests.Integration.Endpoints.TaskAttachments.Commands;

[Collection("DBCollection")]
public class UploadEndpointTests(IntegrationTestFixture fixture)
{
    [Fact]
    public async Task Upload_WithoutAuthorization_ReturnsUnauthorized()
    {
        ProjectTestHelper.ClearAuthorization(fixture.Client);

        using var content = TaskAttachmentTestHelper.CreateFileContent();
        var response = await fixture.Client.PostAsync(
            $"/api/tasks/{Guid.NewGuid()}/attachments", content);

        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
    }

    [Fact]
    public async Task Upload_TaskOwner_ReturnsOk()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);
        var task = await ProjectTestHelper.CreateTaskAsync(fixture.Client);

        using var content = TaskAttachmentTestHelper.CreateFileContent();
        var response = await fixture.Client.PostAsync(
            $"/api/tasks/{task.Id}/attachments", content);

        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]
    public async Task Upload_ExecutorParticipant_ReturnsOk()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);
        var task = await ProjectTestHelper.CreateTaskAsync(fixture.Client);

        var executor = await ProjectTestHelper.RegisterUserAsync(
            fixture.Client, UserRole.Executor);
        ProjectTestHelper.Authorize(fixture.Client, executor.Token);

        await fixture.Client.PostAsync($"/api/projecttask/{task.Id}/respond", null);

        ProjectTestHelper.Authorize(fixture.Client, customer.Token);
        await fixture.Client.PostAsJsonAsync(
            $"/api/projecttask/{task.Id}/assign",
            new Web_Api.Controllers.Projects.AssignExecutorProjectTaskRequestWithId(
                task.Id, executor.Id));

        ProjectTestHelper.Authorize(fixture.Client, executor.Token);

        using var content = TaskAttachmentTestHelper.CreateFileContent();
        var response = await fixture.Client.PostAsync(
            $"/api/tasks/{task.Id}/attachments", content);

        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]
    public async Task Upload_WithoutFile_ReturnsBadRequest()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);
        var task = await ProjectTestHelper.CreateTaskAsync(fixture.Client);

        using var content = new MultipartFormDataContent();
        var response = await fixture.Client.PostAsync(
            $"/api/tasks/{task.Id}/attachments", content);

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Upload_EmptyFile_ReturnsBadRequest()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);
        var task = await ProjectTestHelper.CreateTaskAsync(fixture.Client);

        using var content = TaskAttachmentTestHelper.CreateFileContent(
            content: []);

        var response = await fixture.Client.PostAsync(
            $"/api/tasks/{task.Id}/attachments", content);

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Upload_NonExistingTask_ReturnsNotFound()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);

        using var content = TaskAttachmentTestHelper.CreateFileContent();
        var response = await fixture.Client.PostAsync(
            $"/api/tasks/{Guid.NewGuid()}/attachments", content);

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Upload_NonParticipant_ReturnsForbidden()
    {
        var owner = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, owner.Token);
        var task = await ProjectTestHelper.CreateTaskAsync(fixture.Client);

        var anotherCustomer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, anotherCustomer.Token);

        using var content = TaskAttachmentTestHelper.CreateFileContent();
        var response = await fixture.Client.PostAsync(
            $"/api/tasks/{task.Id}/attachments", content);

        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
    }

    [Fact]
    public async Task Upload_CancelledTask_ReturnsBadRequest()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);
        var task = await ProjectTestHelper.CreateTaskAsync(fixture.Client);

        await fixture.Client.PostAsync(
            $"/api/projecttask/{task.Id}/cancel", null);

        using var content = TaskAttachmentTestHelper.CreateFileContent();
        var response = await fixture.Client.PostAsync(
            $"/api/tasks/{task.Id}/attachments", content);

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }
}