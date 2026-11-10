using FluentAssertions;
using Shared.Enums;
using System.Net;
using System.Net.Http.Json;
using Task_Marketplace.Shared.Dtos.Requests.ProjectTasks.Commands;
using Task_Marketplace.Tests.Integration.Infrastructure;
using Xunit;

namespace Task_Marketplace.Tests.Integration.Endpoints.Projects.Commands;

[Collection("DBCollection")]
public class CreateEndpointTests(IntegrationTestFixture fixture)
{
    [Fact]
    public async Task Create_WithoutAuthorization_ReturnsUnauthorized()
    {
        ProjectTestHelper.ClearAuthorization(fixture.Client);
        var response = await fixture.Client.PostAsJsonAsync("/api/projecttask", ValidRequest());
        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
    }

    [Fact]
    public async Task Create_ValidData_ReturnsCreated()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);

        var response = await fixture.Client.PostAsJsonAsync("/api/projecttask", ValidRequest());
        response.StatusCode.Should().Be(HttpStatusCode.Created);
    }

    [Fact]
    public async Task Create_ExecutorRole_ReturnsForbidden()
    {
        var executor = await ProjectTestHelper.RegisterUserAsync(fixture.Client, UserRole.Executor);
        ProjectTestHelper.Authorize(fixture.Client, executor.Token);

        var response = await fixture.Client.PostAsJsonAsync("/api/projecttask", ValidRequest());
        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
    }

    [Fact]
    public async Task Create_EmptyTitle_ReturnsBadRequest()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);

        var request = ValidRequest();
        request.Title = string.Empty;

        var response = await fixture.Client.PostAsJsonAsync("/api/projecttask", request);
        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Create_EmptyDescription_ReturnsBadRequest()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);

        var request = ValidRequest();
        request.Description = string.Empty;

        var response = await fixture.Client.PostAsJsonAsync("/api/projecttask", request);
        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Create_NegativePrice_ReturnsBadRequest()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);

        var request = ValidRequest();
        request.Price = -1;

        var response = await fixture.Client.PostAsJsonAsync("/api/projecttask", request);
        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Create_PastStartDate_ReturnsBadRequest()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);

        var request = ValidRequest();
        request.StartsAt = DateTimeOffset.UtcNow.AddDays(-1);

        var response = await fixture.Client.PostAsJsonAsync("/api/projecttask", request);
        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Create_EndBeforeStart_ReturnsBadRequest()
    {
        var customer = await ProjectTestHelper.RegisterUserAsync(fixture.Client);
        ProjectTestHelper.Authorize(fixture.Client, customer.Token);

        var request = ValidRequest();
        request.StartsAt = DateTimeOffset.UtcNow.AddDays(2);
        request.EndsAt = DateTimeOffset.UtcNow.AddDays(1);

        var response = await fixture.Client.PostAsJsonAsync("/api/projecttask", request);
        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    private static CreateRequest ValidRequest() => new()
    {
        Title = "Test task",
        Description = "Test description",
        Price = 100,
        StartsAt = DateTimeOffset.UtcNow.AddDays(1),
        EndsAt = DateTimeOffset.UtcNow.AddDays(2)
    };
}