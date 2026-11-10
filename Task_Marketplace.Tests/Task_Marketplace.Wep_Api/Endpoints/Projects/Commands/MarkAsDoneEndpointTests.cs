using FluentAssertions;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;
using System.Net;
using System.Net.Http.Json;
using Task_Marketplace.Tests.Integration.Infrastructure;
using Web_Api.Controllers.Projects;
using Xunit;

namespace Task_Marketplace.Tests.Integration.Endpoints.Projects.Commands;

[Collection("DBCollection")]
public class MarkAsDoneEndpointTests(IntegrationTestFixture fixture)
{
    [Fact]
    public async Task MarkAsDone_WithoutAuthorization_ReturnsUnauthorized()
    {
        ProjectTestHelper.ClearAuthorization(fixture.Client);
        var id = Guid.NewGuid();

        var response = await fixture.Client.PostAsJsonAsync(
            $"/api/projecttask/{id}/mark-as-done",
            new MarkAsDoneProjectTaskRequestWithId(id, null));

        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
    }

    [Fact]
    public async Task MarkAsDone_AssignedTask_ReturnsNoContent()
    {
        var (customer, task, _) = await CreateAssignedTaskAsync();
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);

        var response = await fixture.Client.PostAsJsonAsync(
            $"/api/projecttask/{task.Id}/mark-as-done",
            new MarkAsDoneProjectTaskRequestWithId(task.Id, 5));

        response.StatusCode.Should().Be(HttpStatusCode.NoContent);
    }

    [Fact]
    public async Task MarkAsDone_NonExistingTask_ReturnsNotFound()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);
        var id = Guid.NewGuid();

        var response = await fixture.Client.PostAsJsonAsync(
            $"/api/projecttask/{id}/mark-as-done",
            new MarkAsDoneProjectTaskRequestWithId(id, null));

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task MarkAsDone_TaskNotInProgress_ReturnsBadRequest()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);
        var task = await ProjectTestHelper.CreateTaskAsync(fixture.Client);

        var response = await fixture.Client.PostAsJsonAsync(
            $"/api/projecttask/{task.Id}/mark-as-done",
            new MarkAsDoneProjectTaskRequestWithId(task.Id, null));

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task MarkAsDone_InvalidRating_ReturnsBadRequest()
    {
        var (customer, task, _) = await CreateAssignedTaskAsync();
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);

        var response = await fixture.Client.PostAsJsonAsync(
            $"/api/projecttask/{task.Id}/mark-as-done",
            new MarkAsDoneProjectTaskRequestWithId(task.Id, 6));

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task MarkAsDone_OtherCustomer_ReturnsBadRequest()
    {
        var (_, task, _) = await CreateAssignedTaskAsync();
        var anotherCustomer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, anotherCustomer.Token);

        var response = await fixture.Client.PostAsJsonAsync(
            $"/api/projecttask/{task.Id}/mark-as-done",
            new MarkAsDoneProjectTaskRequestWithId(task.Id, 5));

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task MarkAsDone_ExecutorRole_ReturnsForbidden()
    {
        var executor = await ProjectTestHelper.RegisterUserAsync(
            fixture.Client, UserRole.Executor);
        ProjectTestHelper.Authorize(fixture.Client, executor.Token);
        var id = Guid.NewGuid();

        var response = await fixture.Client.PostAsJsonAsync(
            $"/api/projecttask/{id}/mark-as-done",
            new MarkAsDoneProjectTaskRequestWithId(id, null));

        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
    }

    private async Task<(TestUser Customer, ProjectTaskDto Task, TestUser Executor)> CreateAssignedTaskAsync()
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
            new AssignExecutorProjectTaskRequestWithId(task.Id, executor.Id));

        return (customer, task, executor);
    }
}