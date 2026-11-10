using FluentAssertions;
using Shared.Enums;
using System.Net;
using System.Net.Http.Json;
using Task_Marketplace.Shared.Dtos.Requests.Users.Commands;
using Task_Marketplace.Tests.Integration.Infrastructure;
using Xunit;

namespace Task_Marketplace.Tests.Integration.Endpoints.Users.Commands;

[Collection("DBCollection")]
public class ChangeRoleEndpointTests(IntegrationTestFixture fixture)
{
    [Fact]
    public async Task ChangeRole_WithoutAuthorization_ReturnsUnauthorized()
    {
        ProjectTestHelper.ClearAuthorization(fixture.Client);
        var id = Guid.NewGuid();

        var response = await fixture.Client.PatchAsJsonAsync(
            $"/api/user/{id}/role",
            new ChangeRoleUserRequest(id, UserRole.Executor));

        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
    }

    [Fact]
    public async Task ChangeRole_Admin_ReturnsNoContent()
    {
        var admin = await ProjectTestHelper.LoginAsAdminAsync(fixture.Client);
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, admin.Token);

        var response = await fixture.Client.PatchAsJsonAsync(
            $"/api/user/{customer.Id}/role",
            new ChangeRoleUserRequest(customer.Id, UserRole.Executor));

        response.StatusCode.Should().Be(HttpStatusCode.NoContent);
    }

    [Fact]
    public async Task ChangeRole_CustomerRole_ReturnsForbidden()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        var anotherCustomer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);

        var response = await fixture.Client.PatchAsJsonAsync(
            $"/api/user/{anotherCustomer.Id}/role",
            new ChangeRoleUserRequest(anotherCustomer.Id, UserRole.Executor));

        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
    }

    [Fact]
    public async Task ChangeRole_ExecutorRole_ReturnsForbidden()
    {
        var executor = await ProjectTestHelper.RegisterUserAsync(
            fixture.Client, UserRole.Executor);
        ProjectTestHelper.Authorize(fixture.Client, executor.Token);
        var id = Guid.NewGuid();

        var response = await fixture.Client.PatchAsJsonAsync(
            $"/api/user/{id}/role",
            new ChangeRoleUserRequest(id, UserRole.Customer));

        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
    }

    [Fact]
    public async Task ChangeRole_NonExistingUser_ReturnsNotFound()
    {
        var admin = await ProjectTestHelper.LoginAsAdminAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, admin.Token);
        var id = Guid.NewGuid();

        var response = await fixture.Client.PatchAsJsonAsync(
            $"/api/user/{id}/role",
            new ChangeRoleUserRequest(id, UserRole.Executor));

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }
}