using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.ProjectTasks.Queries.SearchTasks;

public interface ISearchTasksQuery
    : IRequest<Result<PagedResult<ProjectTaskDto>>>;