using Application.Mappers;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.ProjectTasks.Queries.SearchTasks;

public class SearchCustomerTasksHandler
    : IRequestHandler<SearchCustomerTasksQuery, Result<PagedResult<ProjectTaskDto>>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;

    public SearchCustomerTasksHandler(IProjectTaskQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result<PagedResult<ProjectTaskDto>>> Handle(
        SearchCustomerTasksQuery request,
        CancellationToken cancellationToken = default)
    {
        var paged = await _queryRepository.SearchByCustomerIdAsync(
            request.CustomerId,
            request.Query,
            request.Page,
            request.PageSize,
            cancellationToken);

        var dtos = paged.Collection
             .Select(t => ProjectTaskMapper.ToDto(t))
             .ToList();

        var result = PagedResult<ProjectTaskDto>.Create(
            dtos,
            paged.Page,
            paged.PageSize,
            paged.TotalCount);

        return Result<PagedResult<ProjectTaskDto>>.Success(result);
    }
}