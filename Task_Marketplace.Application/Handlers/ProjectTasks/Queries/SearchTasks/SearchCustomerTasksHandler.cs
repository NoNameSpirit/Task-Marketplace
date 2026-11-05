using Domain.Configuration;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Task_Marketplace.Application.Interfaces.Repositories.ProjectTasks;
using Task_Marketplace.Application.Mappers;

namespace Task_Marketplace.Application.Handlers.ProjectTasks.Queries.SearchTasks;

public class SearchCustomerTasksHandler
    : IRequestHandler<SearchCustomerTasksQuery, Result<PagedResult<ProjectTaskDto>>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly AppConfiguration _appConfig;

    public SearchCustomerTasksHandler(
        IProjectTaskQueryRepository queryRepository,
        AppConfiguration appConfig)
    {
        _queryRepository = queryRepository;
        _appConfig = appConfig;
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
             .Select(t => ProjectTaskMapper.ToDto(t, _appConfig.Currency))
             .ToList();

        var result = PagedResult<ProjectTaskDto>.Create(
            dtos,
            paged.Page,
            paged.PageSize,
            paged.TotalCount);

        return Result<PagedResult<ProjectTaskDto>>.Success(result);
    }
}