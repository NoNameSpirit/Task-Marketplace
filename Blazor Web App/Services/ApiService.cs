using Blazor_Web_App.Services.LocalStorage;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos.Requests.ProjectTasks;
using Shared.Dtos.Requests.Users;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Dtos.Responses.Users;
using System.Text.Json;

namespace Blazor_Web_App.Services;

public class ApiService
{
    private readonly HttpClient _httpClient;
    private readonly ILocalStorageService _localStorage;

    private readonly JsonSerializerOptions _options = new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    };

    public ApiService(HttpClient httpClient, ILocalStorageService localStorage)
    {
        _httpClient = httpClient;
        _localStorage = localStorage;
    }

    private async Task SetAuthHeaderAsync(
        CancellationToken cancellationToken = default)
    {
        var token = await _localStorage.GetItemAsync(nameof(AuthDto.Token));
        if (!string.IsNullOrEmpty(token))
        {
            _httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        }
    }
    public async Task<Result<AuthDto>> RegisterAsync(
        RegisterUserDto registerUserDto,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.PostAsJsonAsync(
            "api/auth/register",
            registerUserDto,
            cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            var problemDetails = await response.Content.ReadFromJsonAsync<ProblemDetails>(cancellationToken);

            return Result<AuthDto>.Failure(problemDetails!.Detail!);
        }

        var authDto = await response.Content.ReadFromJsonAsync<AuthDto>(_options, cancellationToken);

        return Result<AuthDto>.Success(authDto!);
    }

    public async Task<Result<AuthDto>> LoginAsync(
        LoginDto loginDto,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.PostAsJsonAsync(
            "api/auth/login",
            loginDto,
            cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            var problemDetails = await response.Content.ReadFromJsonAsync<ProblemDetails>(cancellationToken);

            return Result<AuthDto>.Failure(problemDetails?.Detail!);
        }

        var authDto = await response.Content.ReadFromJsonAsync<AuthDto>(_options, cancellationToken);

        return Result<AuthDto>.Success(authDto!);
    }

    public async Task<Result<PagedResult<ProjectTaskDto>>> GetMyTasksAsync(
        Guid customerId,
        int page = 1,
        int pageSize = 10,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"api/projecttask/customer/{customerId}?page={page}&pageSize={pageSize}",
            cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            return Result<PagedResult<ProjectTaskDto>>.Failure("Failed to load tasks");
        }

        var result = await response.Content.ReadFromJsonAsync<PagedResult<ProjectTaskDto>>(_options, cancellationToken);

        return Result<PagedResult<ProjectTaskDto>>.Success(result!);
    }

    public async Task<Result<ProjectTaskDto>> CreateTaskAsync(
        CreateProjectTaskDto dto,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.PostAsJsonAsync(
            "api/projecttask",
            dto,
            cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            var problem = await response.Content.ReadFromJsonAsync<ProblemDetails>(cancellationToken);

            return Result<ProjectTaskDto>.Failure(problem?.Detail!);
        }

        var task = await response.Content.ReadFromJsonAsync<ProjectTaskDto>(cancellationToken);

        return Result<ProjectTaskDto>.Success(task!);
    }

    public async Task<Result> DeleteTaskAsync(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.DeleteAsync(
            $"api/projecttask/{id}",
            cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            return Result.Failure("Delete failed");
        }

        return Result.Success();
    }

    public async Task<Result<PagedResult<ProjectTaskDto>>> GetPublishedTasksAsync(
        int page = 1,
        int pageSize = 10,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"api/projecttask/published?page={page}&pageSize={pageSize}",
            cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            return Result<PagedResult<ProjectTaskDto>>.Failure("Failed to load published tasks");
        }

        var result = await response.Content.ReadFromJsonAsync<PagedResult<ProjectTaskDto>>(_options, cancellationToken);

        return Result<PagedResult<ProjectTaskDto>>.Success(result!);
    }

    public async Task<Result> RespondToTaskAsync(
        Guid taskId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var executorIdStr = await _localStorage.GetItemAsync(nameof(AuthDto.Id));

        if (string.IsNullOrEmpty(executorIdStr))
        {
            return Result.Failure("User ID not found");
        }

        var body = new { ExecutorId = executorIdStr };

        var response = await _httpClient.PostAsJsonAsync(
            $"api/projecttask/{taskId}/respond",
            body,
            cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            var problem = await response.Content.ReadFromJsonAsync<ProblemDetails>(cancellationToken);
            return Result.Failure(problem?.Detail ?? "Failed to respond to task");
        }

        return Result.Success();
    }

    public async Task<Result<List<TaskResponseDto>>> GetTaskResponsesAsync(
        Guid taskId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"api/projecttask/{taskId}/responses",
            cancellationToken);

        if (!response.IsSuccessStatusCode)
            return Result<List<TaskResponseDto>>.Failure("Failed to load responses");

        var result = await response.Content.ReadFromJsonAsync<List<TaskResponseDto>>(_options, cancellationToken);
        return Result<List<TaskResponseDto>>.Success(result!);
    }

    public async Task<Result> AssignExecutorAsync(
        Guid taskId,
        Guid executorId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var body = new { ExecutorId = executorId.ToString() };

        var response = await _httpClient.PostAsJsonAsync(
            $"api/projecttask/{taskId}/assign",
            body,
            cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            var problem = await response.Content.ReadFromJsonAsync<ProblemDetails>(cancellationToken);

            return Result.Failure(problem?.Detail!);
        }

        return Result.Success();
    }

    public async Task<Result<ChatDto>> CreateChatAsync(
    Guid taskId,
    CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.PostAsync(
            $"api/chat?projectTaskId={taskId}",
            null,
            cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            var problem = await response.Content.ReadFromJsonAsync<ProblemDetails>(cancellationToken);

            return Result<ChatDto>.Failure(problem?.Detail ?? "Failed to create chat");
        }

        var chat = await response.Content.ReadFromJsonAsync<ChatDto>(_options, cancellationToken);

        return Result<ChatDto>.Success(chat!);
    }

    public async Task<Result<ChatDto>> GetChatByTaskIdAsync(
        Guid taskId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"api/chat/task/{taskId}",
            cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            return Result<ChatDto>.Failure("Chat not found");
        }

        var chat = await response.Content.ReadFromJsonAsync<ChatDto>(_options, cancellationToken);

        return Result<ChatDto>.Success(chat!);
    }

    public async Task<Result> SendMessageAsync(
        Guid chatId,
        string text,
        Guid senderId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var body = new
        {
            Text = text,
            SenderId = senderId.ToString()
        };

        var response = await _httpClient.PostAsJsonAsync(
            $"api/chat/{chatId}/messages",
            body,
            cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            var problem = await response.Content.ReadFromJsonAsync<ProblemDetails>(cancellationToken);

            return Result.Failure(problem?.Detail ?? "Failed to send message");
        }

        return Result.Success();
    }

    public async Task<Result<PagedResult<ProjectTaskDto>>> GetAssignedTasksAsync(
        Guid executorId,
        int page = 1,
        int pageSize = 10,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"api/projecttask/assigned/{executorId}?page={page}&pageSize={pageSize}",
            cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            return Result<PagedResult<ProjectTaskDto>>.Failure("Failed to load assigned tasks");
        }

        var result = await response.Content.ReadFromJsonAsync<PagedResult<ProjectTaskDto>>(
            _options,
            cancellationToken);

        return Result<PagedResult<ProjectTaskDto>>.Success(result!);
    }

    public async Task<Result<ProjectTaskDto>> GetTaskByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"api/projecttask/{id}",
            cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            return Result<ProjectTaskDto>.Failure("Task not found");
        }

        var task = await response.Content.ReadFromJsonAsync<ProjectTaskDto>(_options, cancellationToken);

        return Result<ProjectTaskDto>.Success(task!);
    }

    public async Task<Result> CancelTaskAsync(
    Guid taskId,
    CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.PostAsync(
            $"api/projecttask/{taskId}/cancel",
            null,
            cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            var problem = await response.Content.ReadFromJsonAsync<ProblemDetails>(cancellationToken);

            return Result.Failure(problem?.Detail ?? "Failed to cancel task");
        }

        return Result.Success();
    }

    public async Task<Result> MarkAsDoneAsync(
        Guid taskId,
        decimal? rating,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var body = new { Rating = rating };

        var response = await _httpClient.PostAsJsonAsync(
            $"api/projecttask/{taskId}/mark-as-done",
            body,
            cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            var problem = await response.Content.ReadFromJsonAsync<ProblemDetails>(cancellationToken);

            return Result.Failure(problem?.Detail ?? "Failed to mark as done");
        }

        return Result.Success();
    }
}