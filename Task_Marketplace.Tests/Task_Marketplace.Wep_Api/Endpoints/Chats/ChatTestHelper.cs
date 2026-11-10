using Shared.Dtos.Responses.Chats;
using Shared.Enums;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Task_Marketplace.Shared.Dtos.Requests.Auth.Commands;
using Task_Marketplace.Shared.Dtos.Requests.Chats.Commands;
using Task_Marketplace.Shared.Dtos.Requests.ProjectTasks.Commands;

namespace Task_Marketplace.Tests.Integration.Infrastructure;

public static class ChatTestHelper
{
    public static async Task<string> RegisterUserAsync(
        HttpClient client,
        UserRole role = UserRole.Customer)
    {
        var request = new RegisterRequest(
            $"user-{Guid.NewGuid():N}",
            "Password123!",
            role);

        var response = await client.PostAsJsonAsync(
            "/api/auth/register",
            request);

        response.EnsureSuccessStatusCode();

        var auth = await response.Content.ReadFromJsonAsync<AuthResponse>();

        return auth!.Token;
    }

    public static async Task<Guid> CreateTaskAsync(HttpClient client)
    {
        var request = new CreateRequest
        {
            Title = "Test task",
            Description = "Test description",
            Price = 100,
            StartsAt = DateTimeOffset.UtcNow.AddDays(1),
            EndsAt = DateTimeOffset.UtcNow.AddDays(2)
        };

        var response = await client.PostAsJsonAsync(
            "/api/projecttask",
            request);

        response.EnsureSuccessStatusCode();

        var task = await response.Content.ReadFromJsonAsync<TaskResponse>();

        return Guid.Parse(task!.Id);
    }

    public static async Task<ChatDto> CreateChatAsync(
        HttpClient client,
        Guid taskId)
    {
        var response = await client.PostAsJsonAsync(
            "/api/chat",
            new CreateChatRequest(taskId));

        response.EnsureSuccessStatusCode();

        return (await response.Content.ReadFromJsonAsync<ChatDto>())!;
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


    private record AuthResponse(string Token);
    private record TaskResponse(string Id);
}