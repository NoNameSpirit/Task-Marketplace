using Domain.Entities;
using Domain.Shared;
using Infrastructure.Repositories.ProjectTasks.Queries;
using MediatR;

namespace Application.ProjectTasks.Queries.GetPublishedTasks;

public class GetPublishedTasksHandler : IRequestHandler<GetPublishedTasksQuery, PagedResult<ProjectTask>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;

    public GetPublishedTasksHandler(IProjectTaskQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<PagedResult<ProjectTask>> Handle(
        GetPublishedTasksQuery request,
        CancellationToken cancellationToken = default)
    {
        return await _queryRepository.GetPublishedAsync(request.Page, request.PageSize, cancellationToken);
    }
}