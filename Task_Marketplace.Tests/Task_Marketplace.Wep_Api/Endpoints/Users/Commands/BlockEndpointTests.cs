using FluentAssertions;
using Shared.Enums;
using System.Net;
using Task_Marketplace.Tests.Integration.Infrastructure;
using Xunit;

namespace Task_Marketplace.Tests.Integration.Endpoints.Users.Commands;

[Collection("DBCollection")]
public class BlockEndpointTests(IntegrationTestFixture fixture)
{
    [Fact]
    public async Task Block_WithoutAuthorization_ReturnsUnauthorized()
    {
        ProjectTestHelper.ClearAuthorization(fixture.Client);

        var response = await fixture.Client.PostAsync(
            $"/api/user/{Guid.NewGuid()}/block", null);

        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
    }

    [Fact]
    public async Task Block_Admin_ReturnsNoContent()
    {
        var admin = await ProjectTestHelper.LoginAsAdminAsync(fixture.Client);
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, admin.Token);

        var response = await fixture.Client.PostAsync(
            $"/api/user/{customer.Id}/block", null);

        response.StatusCode.Should().Be(HttpStatusCode.NoContent);
    }

    [Fact]
    public async Task Block_CustomerRole_ReturnsForbidden()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);

        var response = await fixture.Client.PostAsync(
            $"/api/user/{Guid.NewGuid()}/block", null);

        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
    }

    [Fact]
    public async Task Block_ExecutorRole_ReturnsForbidden()
    {
        var executor = await ProjectTestHelper.RegisterUserAsync(
            fixture.Client, UserRole.Executor);
        ProjectTestHelper.Authorize(fixture.Client, executor.Token);

        var response = await fixture.Client.PostAsync(
            $"/api/user/{Guid.NewGuid()}/block", null);

        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
    }

    [Fact]
    public async Task Block_NonExistingUser_ReturnsNotFound()
    {
        var admin = await ProjectTestHelper.LoginAsAdminAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, admin.Token);

        var response = await fixture.Client.PostAsync(
            $"/api/user/{Guid.NewGuid()}/block", null);

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }
}