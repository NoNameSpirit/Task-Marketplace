using Application.Mappers;
using Domain.Config;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Microsoft.Extensions.Options;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Task_Marketplace.Application.Handlers.ProjectTasks.Queries.SearchTasks;

public class SearchCustomerTasksHandler
    : IRequestHandler<SearchCustomerTasksQuery, Result<PagedResult<ProjectTaskDto>>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly AppConfig _appConfig;

    public SearchCustomerTasksHandler(
        IProjectTaskQueryRepository queryRepository,
        IOptions<AppConfig> appConfig)
    {
        _queryRepository = queryRepository;
        _appConfig = appConfig.Value;
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