using Application.Mappers;
using Domain.Config;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Microsoft.Extensions.Options;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.ProjectTasks.Queries.GetAssigned;

public class GetAssignedTasksHandler : IRequestHandler<GetAssignedTasksQuery, Result<PagedResult<ProjectTaskDto>>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly AppConfig _appConfig;

    public GetAssignedTasksHandler(
        IProjectTaskQueryRepository queryRepository,
        IOptions<AppConfig> appConfig)
    {
        _queryRepository = queryRepository;
        _appConfig = appConfig.Value;
    }

    public async Task<Result<PagedResult<ProjectTaskDto>>> Handle(
        GetAssignedTasksQuery request,
        CancellationToken cancellationToken = default)
    {
        var paged = await _queryRepository.GetByExecutorIdAsync(
            request.ExecutorId,
            request.Page,
            request.PageSize,
            cancellationToken);

        return Result<PagedResult<ProjectTaskDto>>.Success(
            ProjectTaskMapper.ToPagedDto(
                paged,
                _appConfig.Currency));
    }
}
