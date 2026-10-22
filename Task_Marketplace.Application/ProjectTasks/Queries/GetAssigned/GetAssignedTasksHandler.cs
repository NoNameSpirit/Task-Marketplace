using Application.Interfaces;
using Application.Mappers;
using Domain.Config;
using Domain.Constants;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Microsoft.Extensions.Options;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;

namespace Application.ProjectTasks.Queries.GetAssigned;

public class GetAssignedTasksHandler : IRequestHandler<GetAssignedTasksQuery, Result<PagedResult<ProjectTaskDto>>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly ICurrentUser _currentUser;
    private readonly AppConfig _appConfig;

    public GetAssignedTasksHandler(
        IProjectTaskQueryRepository queryRepository,
        IOptions<AppConfig> appConfig,
        ICurrentUser currentUser)
    {
        _queryRepository = queryRepository;
        _appConfig = appConfig.Value;
        _currentUser = currentUser;
    }

    public async Task<Result<PagedResult<ProjectTaskDto>>> Handle(
        GetAssignedTasksQuery request,
        CancellationToken cancellationToken = default)
    {
        if (request.ExecutorId != _currentUser.Id)
        {
            return Result<PagedResult<ProjectTaskDto>>.Failure(
                ErrorMessages.Forbidden,
                ErrorType.Forbidden);
        }

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
