using Application.Mappers;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos;
using Shared.Dtos.ProjectTasks;

namespace Application.ProjectTasks.Queries.GetPublishedTasks;

public class GetPublishedTasksHandler : IRequestHandler<GetPublishedTasksQuery, PagedResult<ProjectTaskDto>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;

    public GetPublishedTasksHandler(IProjectTaskQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<PagedResult<ProjectTaskDto>> Handle(
        GetPublishedTasksQuery request,
        CancellationToken cancellationToken = default)
    {
        var pagedResult = await _queryRepository.GetPublishedAsync(request.Page, request.PageSize, cancellationToken);

        return ProjectTaskMapper.ToPagedDto(pagedResult);
    }
}