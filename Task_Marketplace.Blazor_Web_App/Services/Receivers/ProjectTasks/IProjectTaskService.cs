using Blazor_Web_App.Constants;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Task_Marketplace.Shared.Dtos.Requests.ProjectTasks.Commands;

namespace Blazor_Web_App.Services.Receivers.ProjectTasks;

public interface IProjectTaskService
{
    Task<Result<PagedResult<ProjectTaskDto>>> GetMyTasksAsync(Guid customerId, int page = Pagination.FirstPage, int pageSize = Pagination.DefaultPageSize, CancellationToken cancellationToken = default);

    Task<Result<ProjectTaskDto>> CreateTaskAsync(CreateRequest dto, CancellationToken cancellationToken = default);

    Task<Result> DeleteTaskAsync(Guid id, CancellationToken cancellationToken = default);

    Task<Result<PagedResult<ProjectTaskDto>>> GetPublishedTasksAsync(int page = Pagination.FirstPage, int pageSize = Pagination.DefaultPageSize, CancellationToken cancellationToken = default);

    Task<Result> RespondToTaskAsync(Guid taskId, CancellationToken cancellationToken = default);

    Task<Result<List<TaskResponseDto>>> GetTaskResponsesAsync(Guid taskId, CancellationToken cancellationToken = default);

    Task<Result> AssignExecutorAsync(Guid taskId, Guid executorId, CancellationToken cancellationToken = default);

    Task<Result<PagedResult<ProjectTaskDto>>> GetAssignedTasksAsync(Guid executorId, int page = Pagination.FirstPage, int pageSize = Pagination.DefaultPageSize, CancellationToken cancellationToken = default);

    Task<Result<ProjectTaskDto>> GetTaskByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<Result> CancelTaskAsync(Guid taskId, CancellationToken cancellationToken = default);

    Task<Result> MarkAsDoneAsync(Guid taskId, decimal? rating, CancellationToken cancellationToken = default);

    Task<Result<PagedResult<ProjectTaskDto>>> SearchTasksAsync(string query, int page = Pagination.FirstPage, int pageSize = Pagination.DefaultPageSize, CancellationToken cancellationToken = default);

    Task<Result> UpdateTaskAsync(Guid id, UpdateRequest dto, CancellationToken cancellationToken = default);
}