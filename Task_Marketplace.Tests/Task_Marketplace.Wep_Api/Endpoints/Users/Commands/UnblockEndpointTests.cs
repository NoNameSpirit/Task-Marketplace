using FluentAssertions;
using Shared.Enums;
using System.Net;
using Task_Marketplace.Tests.Integration.Infrastructure;
using Xunit;

namespace Task_Marketplace.Tests.Integration.Endpoints.Users.Commands;

[Collection("DBCollection")]
public class UnblockEndpointTests(IntegrationTestFixture fixture)
{
    [Fact]
    public async Task Unblock_WithoutAuthorization_ReturnsUnauthorized()
    {
        ProjectTestHelper.ClearAuthorization(fixture.Client);

        var response = await fixture.Client.PostAsync(
            $"/api/user/{Guid.NewGuid()}/unblock", null);

        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
    }

    [Fact]
    public async Task Unblock_Admin_ReturnsNoContent()
    {
        var admin = await ProjectTestHelper.LoginAsAdminAsync(fixture.Client);
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, admin.Token);

        await fixture.Client.PostAsync($"/api/user/{customer.Id}/block", null);

        var response = await fixture.Client.PostAsync(
            $"/api/user/{customer.Id}/unblock", null);

        response.StatusCode.Should().Be(HttpStatusCode.NoContent);
    }

    [Fact]
    public async Task Unblock_CustomerRole_ReturnsForbidden()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);

        var response = await fixture.Client.PostAsync(
            $"/api/user/{Guid.NewGuid()}/unblock", null);

        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
    }

    [Fact]
    public async Task Unblock_ExecutorRole_ReturnsForbidden()
    {
        var executor = await ProjectTestHelper.RegisterUserAsync(
            fixture.Client, UserRole.Executor);
        ProjectTestHelper.Authorize(fixture.Client, executor.Token);

        var response = await fixture.Client.PostAsync(
            $"/api/user/{Guid.NewGuid()}/unblock", null);

        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
    }

    [Fact]
    public async Task Unblock_NonExistingUser_ReturnsNotFound()
    {
        var admin = await ProjectTestHelper.LoginAsAdminAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, admin.Token);

        var response = await fixture.Client.PostAsync(
            $"/api/user/{Guid.NewGuid()}/unblock", null);

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }
}