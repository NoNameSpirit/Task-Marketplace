using FluentAssertions;
using Shared.Enums;
using System.Net;
using System.Net.Http.Json;
using Task_Marketplace.Tests.Integration.Infrastructure;
using Web_Api.Controllers.Projects;
using Xunit;

namespace Task_Marketplace.Tests.Integration.Endpoints.Projects.Commands;

[Collection("DBCollection")]
public class UpdateEndpointTests(IntegrationTestFixture fixture)
{
    [Fact]
    public async Task Update_WithoutAuthorization_ReturnsUnauthorized()
    {
        ProjectTestHelper.ClearAuthorization(fixture.Client);
        var response = await fixture.Client.PutAsJsonAsync(
            $"/api/projecttask/{Guid.NewGuid()}", ValidRequest(Guid.NewGuid()));

        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
    }

    [Fact]
    public async Task Update_Owner_ReturnsNoContent()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);
        var task = await ProjectTestHelper.CreateTaskAsync(fixture.Client);

        var response = await fixture.Client.PutAsJsonAsync(
            $"/api/projecttask/{task.Id}", ValidRequest(task.Id));

        response.StatusCode.Should().Be(HttpStatusCode.NoContent);
    }

    [Fact]
    public async Task Update_OtherCustomer_ReturnsBadRequest()
    {
        var owner = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, owner.Token);
        var task = await ProjectTestHelper.CreateTaskAsync(fixture.Client);

        var anotherCustomer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, anotherCustomer.Token);

        var response = await fixture.Client.PutAsJsonAsync(
            $"/api/projecttask/{task.Id}", ValidRequest(task.Id));

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Update_NonExistingTask_ReturnsNotFound()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);

        var id = Guid.NewGuid();
        var response = await fixture.Client.PutAsJsonAsync(
            $"/api/projecttask/{id}", ValidRequest(id));

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task Update_ExecutorRole_ReturnsForbidden()
    {
        var executor = await ProjectTestHelper.RegisterUserAsync(
            fixture.Client, UserRole.Executor);
        ProjectTestHelper.Authorize(fixture.Client, executor.Token);

        var id = Guid.NewGuid();
        var response = await fixture.Client.PutAsJsonAsync(
            $"/api/projecttask/{id}", ValidRequest(id));

        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
    }

    [Fact]
    public async Task Update_EmptyTitle_ReturnsBadRequest()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);
        var task = await ProjectTestHelper.CreateTaskAsync(fixture.Client);

        var request = ValidRequest(task.Id) with { Title = string.Empty };
        var response = await fixture.Client.PutAsJsonAsync(
            $"/api/projecttask/{task.Id}", request);

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    private static UpdateProjectTaskRequestWithId ValidRequest(Guid id) =>
        new(id, "Updated task", "Updated description", 150,
            DateTimeOffset.UtcNow.AddDays(1), DateTimeOffset.UtcNow.AddDays(2));
}