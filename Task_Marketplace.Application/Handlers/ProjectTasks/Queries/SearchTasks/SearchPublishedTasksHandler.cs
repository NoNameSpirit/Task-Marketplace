using Domain.Configuration;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Task_Marketplace.Application.Interfaces;
using Task_Marketplace.Application.Interfaces.Repositories.ProjectTasks;
using Task_Marketplace.Application.Mappers;

namespace Task_Marketplace.Application.Handlers.ProjectTasks.Queries.SearchTasks;

public class SearchPublishedTasksHandler
    : IRequestHandler<SearchPublishedTasksQuery, Result<PagedResult<ProjectTaskDto>>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly AppConfiguration _appConfig;
    private readonly ICurrentUser _currentUser;

    public SearchPublishedTasksHandler(
        IProjectTaskQueryRepository queryRepository,
        AppConfiguration appConfig,
        ICurrentUser currentUser)
    {
        _queryRepository = queryRepository;
        _appConfig = appConfig;
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