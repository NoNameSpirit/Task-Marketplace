using Application.Interfaces;
using Application.Mappers;
using Domain.Config;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Microsoft.Extensions.Options;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Task_Marketplace.Application.Handlers.ProjectTasks.Queries.SearchTasks;

public class SearchPublishedTasksHandler
    : IRequestHandler<SearchPublishedTasksQuery, Result<PagedResult<ProjectTaskDto>>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly AppConfig _appConfig;
    private readonly ICurrentUser _currentUser;

    public SearchPublishedTasksHandler(
        IProjectTaskQueryRepository queryRepository,
        IOptions<AppConfig> appConfig,
        ICurrentUser currentUser)
    {
        _queryRepository = queryRepository;
        _appConfig = appConfig.Value;
        _currentUser = currentUser;
    }

    public async Task<Result<PagedResult<ProjectTaskDto>>> Handle(
        SearchPublishedTasksQuery request,
        CancellationToken cancellationToken = default)
    {
        var paged = await _queryRepository.SearchPublishedAsync(
            request.Query,
            request.Page,
            request.PageSize,
            cancellationToken);

        var dtos = paged.Collection
            .Select(t => ProjectTaskMapper.ToDto(
                t,
                _appConfig.Currency,
                t.Responses.Any(r => r.ExecutorId == _currentUser.Id)))
            .ToList();

        var result = PagedResult<ProjectTaskDto>.Create(
            dtos,
            paged.Page,
            paged.PageSize,
            paged.TotalCount);

        return Result<PagedResult<ProjectTaskDto>>.Success(result);
    }
}