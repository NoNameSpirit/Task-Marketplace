using Application.Mappers;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.ProjectTasks.Queries.GetAssigned;

public class GetAssignedTasksHandler : IRequestHandler<GetAssignedTasksQuery, Result<PagedResult<ProjectTaskDto>>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;

    public GetAssignedTasksHandler(
        IProjectTaskQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result<PagedResult<ProjectTaskDto>>> Handle(
        GetAssignedTasksQuery request,
        CancellationToken cancellationToken = default)
    {
        var paged = await _queryRepository.GetByExecutorIdAsync(
            request.ExecutorId,
            request.Page,
            request.PageSize,
            cancellationToken);

        return Result<PagedResult<ProjectTaskDto>>.Success(ProjectTaskMapper.ToPagedDto(paged));
    }
}
