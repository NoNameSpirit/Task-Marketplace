using Domain.Entities;
using Domain.Shared;
using MediatR;

namespace Application.ProjectTasks.Queries.GetPublishedTasks;

public record GetPublishedTasksQuery(
    int Page,
    int PageSize) : IRequest<PagedResult<ProjectTask>>;