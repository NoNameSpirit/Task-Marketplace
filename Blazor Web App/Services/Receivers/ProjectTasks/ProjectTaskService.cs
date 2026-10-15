using Blazor_Web_App.Services.LocalStorage;
using Shared.Dtos.Requests.ProjectTasks;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Dtos.Responses.Users;

namespace Blazor_Web_App.Services.Receivers.ProjectTasks;

public class ProjectTaskService(
    HttpClient _httpClient,
    ILocalStorageService _localStorage)
    : BaseService(_httpClient, _localStorage), IProjectTaskService
{
    public async Task<Result<PagedResult<ProjectTaskDto>>> GetMyTasksAsync(
        Guid customerId,
        int page = FirstPageNumber,
        int pageSize = BasePageSize,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"/customer/{customerId}?page={page}&pageSize={pageSize}",
            cancellationToken);

        var result = await HandleResponseAsync<PagedResult<ProjectTaskDto>>(
            response,
            cancellationToken);

        return result;
    }

    public async Task<Result<ProjectTaskDto>> CreateTaskAsync(
        CreateProjectTaskDto dto,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.PostAsJsonAsync(
            string.Empty,
            dto,
            cancellationToken);

        var result = await HandleResponseAsync<ProjectTaskDto>(
            response,
            cancellationToken);

        return result;
    }

    public async Task<Result> DeleteTaskAsync(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.DeleteAsync(
            $"{id}",
            cancellationToken);

        var result = await HandleResponseAsync(
            response,
            cancellationToken);

        return result;
    }

    public async Task<Result<PagedResult<ProjectTaskDto>>> GetPublishedTasksAsync(
        int page = FirstPageNumber,
        int pageSize = BasePageSize,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"published?page={page}&pageSize={pageSize}",
            cancellationToken);

        var result = await HandleResponseAsync<PagedResult<ProjectTaskDto>>(
            response,
            cancellationToken);

        return result;
    }

    public async Task<Result> RespondToTaskAsync(
        Guid taskId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var executorIdStr = await _localStorage
            .GetItemAsync(nameof(AuthDto.Id));

        if (string.IsNullOrEmpty(executorIdStr))
        {
            return Result.Failure("User ID not found");
        }

        var body = new
        {
            ExecutorId = executorIdStr
        };

        var response = await _httpClient.PostAsJsonAsync(
            $"{taskId}/respond",
            body,
            cancellationToken);

        var result = await HandleResponseAsync(
            response,
            cancellationToken);

        return result;
    }

    public async Task<Result<List<TaskResponseDto>>> GetTaskResponsesAsync(
        Guid taskId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"{taskId}/responses",
            cancellationToken);

        var result = await HandleResponseAsync<List<TaskResponseDto>>(
           response,
           cancellationToken);

        return result;
    }

    public async Task<Result> AssignExecutorAsync(
        Guid taskId,
        Guid executorId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var body = new
        {
            ExecutorId = executorId.ToString()
        };

        var response = await _httpClient.PostAsJsonAsync(
            $"{taskId}/assign",
            body,
            cancellationToken);

        var result = await HandleResponseAsync(
            response,
            cancellationToken);

        return result;
    }


    public async Task<Result<PagedResult<ProjectTaskDto>>> GetAssignedTasksAsync(
        Guid executorId,
        int page = FirstPageNumber,
        int pageSize = BasePageSize,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"assigned/{executorId}?page={page}&pageSize={pageSize}",
            cancellationToken);

        var result = await HandleResponseAsync<PagedResult<ProjectTaskDto>>(
           response,
           cancellationToken);

        return result;
    }

    public async Task<Result<ProjectTaskDto>> GetTaskByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"{id}",
            cancellationToken);

        var result = await HandleResponseAsync<ProjectTaskDto>(
           response,
           cancellationToken);

        return result;
    }

    public async Task<Result> CancelTaskAsync(
        Guid taskId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.PostAsync(
            $"{taskId}/cancel",
            null,
            cancellationToken);

        var result = await HandleResponseAsync(
           response,
           cancellationToken);

        return result;
    }

    public async Task<Result> MarkAsDoneAsync(
        Guid taskId,
        decimal? rating,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var body = new
        {
            Rating = rating
        };

        var response = await _httpClient.PostAsJsonAsync(
            $"{taskId}/mark-as-done",
            body,
            cancellationToken);

        var result = await HandleResponseAsync(
           response,
           cancellationToken);

        return result;
    }

    public async Task<Result<PagedResult<ProjectTaskDto>>> SearchTasksAsync(
        string query,
        int page = FirstPageNumber,
        int pageSize = BasePageSize,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"search?query={Uri.EscapeDataString(query)}&page={page}&pageSize={pageSize}",
            cancellationToken);

        var result = await HandleResponseAsync<PagedResult<ProjectTaskDto>>(
            response,
            cancellationToken);

        return result;
    }

    public async Task<Result> UpdateTaskAsync(
        Guid id,
        UpdateProjectTaskDto dto,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.PutAsJsonAsync(
            $"{id}",
            dto,
            cancellationToken);

        var result = await HandleResponseAsync(
           response,
           cancellationToken);

        return result;
    }
}
