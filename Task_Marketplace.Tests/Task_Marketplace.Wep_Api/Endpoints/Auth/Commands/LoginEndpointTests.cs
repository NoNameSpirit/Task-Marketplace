using FluentAssertions;
using Shared.Enums;
using System.Net;
using System.Net.Http.Json;
using Task_Marketplace.Shared.Dtos.Requests.Auth.Commands;
using Task_Marketplace.Tests.Integration.Infrastructure;
using Xunit;

namespace Task_Marketplace.Tests.Integration.Endpoints.Auth;

[Collection("DBCollection")]
public class LoginTests(IntegrationTestFixture fixture)
{
    [Fact]
    public async Task Login_ValidCredentials_ReturnsOk()
    {
        var name = $"user-{Guid.NewGuid():N}";
        var password = "Password123!";

        await fixture.Client.PostAsJsonAsync(
            "/api/auth/register",
            new RegisterRequest(name, password, UserRole.Customer));

        var response = await fixture.Client.PostAsJsonAsync(
            "/api/auth/login",
            new LoginRequest(name, password));

        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]
    public async Task Login_InvalidPassword_ReturnsBadRequest()
    {
        var name = $"user-{Guid.NewGuid():N}";

        await fixture.Client.PostAsJsonAsync(
            "/api/auth/register",
            new RegisterRequest(name, "Password123!", UserRole.Customer));

        var response = await fixture.Client.PostAsJsonAsync(
            "/api/auth/login",
            new LoginRequest(name, "WrongPassword123!"));

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task Login_NonExistingUser_ReturnsNotFound()
    {
        var response = await fixture.Client.PostAsJsonAsync(
            "/api/auth/login",
            new LoginRequest($"unknown-{Guid.NewGuid():N}", "Password123!"));

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }
}