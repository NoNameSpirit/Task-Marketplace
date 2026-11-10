using Shared.Dtos.Responses.ProjectTasks;
using Shared.Dtos.Responses.Users;
using Shared.Enums;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Task_Marketplace.Shared.Dtos.Requests.Auth.Commands;
using Task_Marketplace.Shared.Dtos.Requests.ProjectTasks.Commands;

namespace Task_Marketplace.Tests.Integration.Infrastructure;

public static class ProjectTestHelper
{
    public static async Task<TestUser> RegisterUserAsync(
        HttpClient client,
        UserRole role = UserRole.Customer)
    {
        if (role == UserRole.Admin)
        {
            return await LoginAsAdminAsync(client);
        }

        var request = new RegisterRequest(
            $"user-{Guid.NewGuid():N}",
            TestConstants.Password,
            role);

        var response = await client.PostAsJsonAsync("/api/auth/register", request);
        response.EnsureSuccessStatusCode();

        var auth = await response.Content.ReadFromJsonAsync<AuthDto>();
        var token = auth!.Token;

        return new TestUser(ExtractUserId(token), token);
    }

    public static async Task<TestUser> LoginAsAdminAsync(HttpClient client)
    {
        var response = await client.PostAsJsonAsync(
            "/api/auth/login",
            new LoginRequest("seed-admin", TestConstants.Password));

        response.EnsureSuccessStatusCode();

        var auth = await response.Content.ReadFromJsonAsync<AuthDto>();
        var token = auth!.Token;

        return new TestUser(ExtractUserId(token), token);
    }

    public static async Task<ProjectTaskDto> CreateTaskAsync(HttpClient client)
    {
        var request = new CreateRequest
        {
            Title = "Test task",
            Description = "Test description",
            Price = 100,
            StartsAt = DateTimeOffset.UtcNow.AddDays(1),
            EndsAt = DateTimeOffset.UtcNow.AddDays(2)
        };

        var response = await client.PostAsJsonAsync("/api/projecttask", request);
        response.EnsureSuccessStatusCode();

        return (await response.Content.ReadFromJsonAsync<ProjectTaskDto>())!;
    }

    public static void Authorize(HttpClient client, string token)
    {
        client.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", token);
    }

    public static void ClearAuthorization(HttpClient client)
    {
        client.DefaultRequestHeaders.Authorization = null;
    }

    private static Guid ExtractUserId(string token)
    {
        var jwt = new JwtSecurityTokenHandler().ReadJwtToken(token);

        var idClaim = jwt.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.NameId)
                   ?? jwt.Claims.FirstOrDefault(c => c.Type == "nameid")
                   ?? jwt.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Sub);

        return Guid.Parse(idClaim!.Value);
    }
}

public record TestUser(Guid Id, string Token);