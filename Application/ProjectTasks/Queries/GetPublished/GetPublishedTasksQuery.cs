using MediatR;
using Shared.Dtos;
using Shared.Dtos.ProjectTasks;

namespace Application.ProjectTasks.Queries.GetPublishedTasks;

public record GetPublishedTasksQuery(
    int Page,
    int PageSize) : IRequest<Result<PagedResult<ProjectTaskDto>>>;