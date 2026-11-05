using Domain.Configuration;
using Domain.Constants;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;
using Task_Marketplace.Application.Interfaces;
using Task_Marketplace.Application.Interfaces.Repositories.ProjectTasks;
using Task_Marketplace.Application.Mappers;

namespace Task_Marketplace.Application.Handlers.ProjectTasks.Queries.GetAssigned;

public class GetAssignedTasksHandler : IRequestHandler<GetAssignedTasksQuery, Result<PagedResult<ProjectTaskDto>>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly ICurrentUser _currentUser;
    private readonly AppConfiguration _appConfig;

    public GetAssignedTasksHandler(
        IProjectTaskQueryRepository queryRepository,
        AppConfiguration appConfig,
        ICurrentUser currentUser)
    {
        _queryRepository = queryRepository;
        _appConfig = appConfig;
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
