using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.ProjectTasks.Queries.GetPublishedTasks;

public record GetPublishedTasksQuery(
    int Page,
    int PageSize) : IRequest<Result<PagedResult<ProjectTaskDto>>>;