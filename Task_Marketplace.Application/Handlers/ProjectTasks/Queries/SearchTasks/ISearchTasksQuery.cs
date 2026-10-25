using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Task_Marketplace.Application.Handlers.ProjectTasks.Queries.SearchTasks;

public interface ISearchTasksQuery
    : IRequest<Result<PagedResult<ProjectTaskDto>>>;