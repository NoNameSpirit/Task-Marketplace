using FluentAssertions;
using Shared.Enums;
using System.Net;
using System.Net.Http.Json;
using Task_Marketplace.Shared.Dtos.Requests.Auth.Commands;
using Task_Marketplace.Tests.Integration.Infrastructure;
using Xunit;

namespace Task_Marketplace.Tests.Integration.Endpoints.Auth;

[Collection("DBCollection")]
public class RegisterTests(IntegrationTestFixture fixture)

{
    [Fact]
    public async Task Register_ValidData_ReturnsOk()
    {
        var request = new RegisterRequest(
            $"user-{Guid.NewGuid():N}",
            "Password123!",
            UserRole.Customer);

        var response = await fixture.Client.PostAsJsonAsync(
            "/api/auth/register",
            request);

        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]
    public async Task Register_DuplicateName_ReturnsConflict()
    {
        var request = new RegisterRequest(
            $"user-{Guid.NewGuid():N}",
            "Password123!",
            UserRole.Customer);

        await fixture.Client.PostAsJsonAsync("/api/auth/register", request);

        var response = await fixture.Client.PostAsJsonAsync(
            "/api/auth/register",
            request);

        response.StatusCode.Should().Be(HttpStatusCode.Conflict);
    }
}