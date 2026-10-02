using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.ProjectTasks.Queries.GetAssigned;

public record GetAssignedTasksQuery(
    Guid ExecutorId,
    int Page,
    int PageSize) : IRequest<Result<PagedResult<ProjectTaskDto>>>;
