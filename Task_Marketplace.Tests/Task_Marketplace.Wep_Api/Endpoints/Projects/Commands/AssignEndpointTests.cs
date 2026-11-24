using FluentAssertions;
using Shared.Enums;
using System.Net;
using System.Net.Http.Json;
using Task_Marketplace.Tests.Integration.Infrastructure;
using Web_Api.Controllers.Projects;
using Xunit;

namespace Task_Marketplace.Tests.Integration.Endpoints.Projects.Commands;

[Collection("DBCollection")]
public class AssignEndpointTests(IntegrationTestFixture fixture)
{
    [Fact]
    public async Task Assign_WithoutAuthorization_ReturnsUnauthorized()
    {
        ProjectTestHelper.ClearAuthorization(fixture.Client);
        var response = await fixture.Client.PostAsJsonAsync(
            $"/api/projecttask/{Guid.NewGuid()}/assign",
            new AssignExecutorProjectTaskRequestWithId(Guid.NewGuid(), Guid.NewGuid()));

        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
    }

    [Fact]
    public async Task Assign_ExecutorWhoResponded_ReturnsNoContent()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);
        var task = await ProjectTestHelper.CreateTaskAsync(fixture.Client);

        var executor = await ProjectTestHelper.RegisterUserAsync(
            fixture.Client, UserRole.Executor);
        ProjectTestHelper.Authorize(fixture.Client, executor.Token);
        await fixture.Client.PostAsync($"/api/projecttask/{task.Id}/respond", null);

        ProjectTestHelper.Authorize(fixture.Client, customer.Token);
        var response = await fixture.Client.PostAsJsonAsync(
            $"/api/projecttask/{task.Id}/assign",
            new AssignExecutorProjectTaskRequestWithId(task.Id, executor.Id));

        response.StatusCode.Should().Be(HttpStatusCode.NoContent);
    }

    [Fact]
    public async Task Assign_NonExistingTask_ReturnsNotFound()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);

        var response = await fixture.Client.PostAsJsonAsync(
            $"/api/projecttask/{Guid.NewGuid()}/assign",
            new AssignExecutorProjectTaskRequestWithId(Guid.NewGuid(), Guid.NewGuid()));

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Assign_ExecutorDidNotRespond_ReturnsBadRequest()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);
        var task = await ProjectTestHelper.CreateTaskAsync(fixture.Client);
        var executor = await ProjectTestHelper.RegisterUserAsync(
            fixture.Client, UserRole.Executor);

        var response = await fixture.Client.PostAsJsonAsync(
            $"/api/projecttask/{task.Id}/assign",
            new AssignExecutorProjectTaskRequestWithId(task.Id, executor.Id));

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Assign_OtherCustomer_ReturnsBadRequest()
    {
        var owner = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, owner.Token);
        var task = await ProjectTestHelper.CreateTaskAsync(fixture.Client);

        var executor = await ProjectTestHelper.RegisterUserAsync(
            fixture.Client, UserRole.Executor);
        ProjectTestHelper.Authorize(fixture.Client, executor.Token);
        await fixture.Client.PostAsync($"/api/projecttask/{task.Id}/respond", null);

        var anotherCustomer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, anotherCustomer.Token);

        var response = await fixture.Client.PostAsJsonAsync(
            $"/api/projecttask/{task.Id}/assign",
            new AssignExecutorProjectTaskRequestWithId(task.Id, executor.Id));

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Assign_ExecutorRole_ReturnsForbidden()
    {
        var executor = await ProjectTestHelper.RegisterUserAsync(
            fixture.Client, UserRole.Executor);
        ProjectTestHelper.Authorize(fixture.Client, executor.Token);

        var response = await fixture.Client.PostAsJsonAsync(
            $"/api/projecttask/{Guid.NewGuid()}/assign",
            new AssignExecutorProjectTaskRequestWithId(Guid.NewGuid(), Guid.NewGuid()));

        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
    }
}