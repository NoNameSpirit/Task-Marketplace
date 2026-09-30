using Application.Mappers;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos;
using Shared.Dtos.ProjectTasks;

namespace Application.ProjectTasks.Queries.GetPublishedTasks;

public class GetPublishedTasksHandler : IRequestHandler<GetPublishedTasksQuery, Result<PagedResult<ProjectTaskDto>>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;

    public GetPublishedTasksHandler(IProjectTaskQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result<PagedResult<ProjectTaskDto>>> Handle(
        GetPublishedTasksQuery request,
        CancellationToken cancellationToken = default)
    {
        var pagedResult = await _queryRepository.GetPublishedAsync(
            request.Page,
            request.PageSize,
            cancellationToken);

        return Result<PagedResult<ProjectTaskDto>>.Success(ProjectTaskMapper.ToPagedDto(pagedResult));
    }
}