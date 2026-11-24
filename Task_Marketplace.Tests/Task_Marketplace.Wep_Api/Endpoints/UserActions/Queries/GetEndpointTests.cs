using FluentAssertions;
using Shared.Enums;
using System.Net;
using Task_Marketplace.Tests.Integration.Infrastructure;
using Xunit;

namespace Task_Marketplace.Tests.Integration.Endpoints.UserActions.Queries;

[Collection("DBCollection")]
public class GetEndpointTests(IntegrationTestFixture fixture)
{
    [Fact]
    public async Task Get_WithoutAuthorization_ReturnsUnauthorized()
    {
        ProjectTestHelper.ClearAuthorization(fixture.Client);

        var response = await fixture.Client.GetAsync("/api/useraction?page=1&pageSize=10");

        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
    }

    [Fact]
    public async Task Get_CustomerRole_ReturnsForbidden()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);

        var response = await fixture.Client.GetAsync("/api/useraction?page=1&pageSize=10");

        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
    }

    [Fact]
    public async Task Get_ExecutorRole_ReturnsForbidden()
    {
        var executor = await ProjectTestHelper.RegisterUserAsync(
            fixture.Client, UserRole.Executor);
        ProjectTestHelper.Authorize(fixture.Client, executor.Token);

        var response = await fixture.Client.GetAsync("/api/useraction?page=1&pageSize=10");

        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
    }

    [Fact]
    public async Task Get_AdminRole_ReturnsOk()
    {
        var admin = await ProjectTestHelper.LoginAsAdminAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, admin.Token);

        var response = await fixture.Client.GetAsync("/api/useraction?page=1&pageSize=10");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]
    public async Task Get_FilterByUserId_ReturnsOk()
    {
        var admin = await ProjectTestHelper.LoginAsAdminAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, admin.Token);

        var response = await fixture.Client.GetAsync(
            $"/api/useraction?userId={Guid.NewGuid()}&page=1&pageSize=10");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]
    public async Task Get_FilterByActionType_ReturnsOk()
    {
        var admin = await ProjectTestHelper.LoginAsAdminAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, admin.Token);

        var response = await fixture.Client.GetAsync(
            "/api/useraction?actionType=0&page=1&pageSize=10");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]
    public async Task Get_FilterByUserIdAndActionType_ReturnsOk()
    {
        var admin = await ProjectTestHelper.LoginAsAdminAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, admin.Token);

        var response = await fixture.Client.GetAsync(
            $"/api/useraction?userId={Guid.NewGuid()}&actionType=0&page=1&pageSize=10");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]
    public async Task Get_EmptyResult_ReturnsOk()
    {
        var admin = await ProjectTestHelper.LoginAsAdminAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, admin.Token);

        var response = await fixture.Client.GetAsync(
            $"/api/useraction?userId={Guid.NewGuid()}&page=1&pageSize=10");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]
    public async Task Get_NextPage_ReturnsOk()
    {
        var admin = await ProjectTestHelper.LoginAsAdminAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, admin.Token);

        var response = await fixture.Client.GetAsync(
            "/api/useraction?page=2&pageSize=5");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }
}