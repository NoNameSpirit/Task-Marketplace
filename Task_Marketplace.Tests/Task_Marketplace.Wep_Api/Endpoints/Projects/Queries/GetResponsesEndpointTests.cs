using FluentAssertions;
using Shared.Enums;
using System.Net;
using Task_Marketplace.Tests.Integration.Infrastructure;
using Xunit;

namespace Task_Marketplace.Tests.Integration.Endpoints.Projects.Queries;

[Collection("DBCollection")]
public class GetResponsesEndpointTests(IntegrationTestFixture fixture)
{
    [Fact]
    public async Task GetResponses_WithoutAuthorization_ReturnsUnauthorized()
    {
        ProjectTestHelper.ClearAuthorization(fixture.Client);

        var response = await fixture.Client.GetAsync(
            $"/api/projecttask/{Guid.NewGuid()}/responses");

        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
    }

    [Fact]
    public async Task GetResponses_OwnerWithoutResponses_ReturnsOk()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);
        var task = await ProjectTestHelper.CreateTaskAsync(fixture.Client);

        var response = await fixture.Client.GetAsync(
            $"/api/projecttask/{task.Id}/responses");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]
    public async Task GetResponses_OwnerWithResponses_ReturnsOk()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);
        var task = await ProjectTestHelper.CreateTaskAsync(fixture.Client);

        var executor = await ProjectTestHelper.RegisterUserAsync(
            fixture.Client, UserRole.Executor);
        ProjectTestHelper.Authorize(fixture.Client, executor.Token);
        await fixture.Client.PostAsync($"/api/projecttask/{task.Id}/respond", null);

        ProjectTestHelper.Authorize(fixture.Client, customer.Token);

        var response = await fixture.Client.GetAsync(
            $"/api/projecttask/{task.Id}/responses");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]
    public async Task GetResponses_OtherCustomer_ReturnsForbidden()
    {
        var owner = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, owner.Token);
        var task = await ProjectTestHelper.CreateTaskAsync(fixture.Client);

        var anotherCustomer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, anotherCustomer.Token);

        var response = await fixture.Client.GetAsync(
            $"/api/projecttask/{task.Id}/responses");

        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
    }

    [Fact]
    public async Task GetResponses_NonExistingTask_ReturnsNotFound()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);

        var response = await fixture.Client.GetAsync(
            $"/api/projecttask/{Guid.NewGuid()}/responses");

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task GetResponses_ExecutorRole_ReturnsForbidden()
    {
        var executor = await ProjectTestHelper.RegisterUserAsync(
            fixture.Client, UserRole.Executor);
        ProjectTestHelper.Authorize(fixture.Client, executor.Token);

        var response = await fixture.Client.GetAsync(
            $"/api/projecttask/{Guid.NewGuid()}/responses");

        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
    }
}