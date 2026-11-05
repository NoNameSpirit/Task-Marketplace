using Domain.Configuration;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Task_Marketplace.Application.Interfaces;
using Task_Marketplace.Application.Interfaces.Repositories.ProjectTasks;
using Task_Marketplace.Application.Mappers;

namespace Task_Marketplace.Application.Handlers.ProjectTasks.Queries.GetPublished;

public class GetPublishedTasksHandler : IRequestHandler<GetPublishedTasksQuery, Result<PagedResult<ProjectTaskDto>>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly AppConfiguration _appConfig;
    private readonly ICurrentUser _currentUser;

    public GetPublishedTasksHandler(
        IProjectTaskQueryRepository queryRepository,
        AppConfiguration appConfig,
        ICurrentUser currentUser)
    {
        _queryRepository = queryRepository;
        _appConfig = appConfig;
        _currentUser = currentUser;
    }

    public async Task<Result<PagedResult<ProjectTaskDto>>> Handle(
        GetPublishedTasksQuery request,
        CancellationToken cancellationToken = default)
    {
        var pagedResult = await _queryRepository.GetPublishedAsync(
            request.Page,
            request.PageSize,
            cancellationToken);

        var dtos = pagedResult.Collection
            .Select(t => ProjectTaskMapper.ToDto(
                t,
                _appConfig.Currency,
                t.Responses.Any(r => r.ExecutorId == _currentUser.Id)))
            .ToList();

        var result = PagedResult<ProjectTaskDto>.Create(
            dtos,
            pagedResult.Page,
            pagedResult.PageSize,
            pagedResult.TotalCount);

        return Result<PagedResult<ProjectTaskDto>>.Success(result);
    }
}