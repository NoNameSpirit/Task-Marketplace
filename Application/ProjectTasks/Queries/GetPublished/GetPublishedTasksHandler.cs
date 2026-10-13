using Application.Mappers;
using Domain.Config;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Microsoft.Extensions.Options;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.ProjectTasks.Queries.GetPublishedTasks;

public class GetPublishedTasksHandler : IRequestHandler<GetPublishedTasksQuery, Result<PagedResult<ProjectTaskDto>>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly AppConfig _appConfig;

    public GetPublishedTasksHandler(
        IProjectTaskQueryRepository queryRepository,
        IOptions<AppConfig> appConfig)
    {
        _queryRepository = queryRepository;
        _appConfig = appConfig.Value;
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
                t.Responses.Any(r => r.ExecutorId == request.CurrentUserId)))
            .ToList();

        var result = PagedResult<ProjectTaskDto>.Create(
            dtos,
            pagedResult.Page,
            pagedResult.PageSize,
            pagedResult.TotalCount);

        return Result<PagedResult<ProjectTaskDto>>.Success(result);
    }
}