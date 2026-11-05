using Domain.Configuration;
using Domain.Constants;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;
using Task_Marketplace.Application.Interfaces;
using Task_Marketplace.Application.Interfaces.Repositories.ProjectTasks;
using Task_Marketplace.Application.Mappers;

namespace Task_Marketplace.Application.Handlers.ProjectTasks.Queries.GetByCustomer;

public class GetTasksByCustomerHandler : IRequestHandler<GetTasksByCustomerQuery, Result<PagedResult<ProjectTaskDto>>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly ICurrentUser _currentUser;
    private readonly AppConfiguration _appConfig;

    public GetTasksByCustomerHandler(
        IProjectTaskQueryRepository queryRepository,
        AppConfiguration appConfig,
        ICurrentUser currentUser)
    {
        _queryRepository = queryRepository;
        _appConfig = appConfig;
        _currentUser = currentUser;
    }

    public async Task<Result<PagedResult<ProjectTaskDto>>> Handle(
        GetTasksByCustomerQuery request,
        CancellationToken cancellationToken = default)
    {
        if (request.CustomerId != _currentUser.Id)
        {
            return Result<PagedResult<ProjectTaskDto>>.Failure(
                ErrorMessages.CustomerWithSameId,
                ErrorType.Forbidden);
        }

        var projectTask = await _queryRepository.GetByCustomerIdAsync(
            request.CustomerId,
            request.Page,
            request.PageSize,
            cancellationToken);

        return Result<PagedResult<ProjectTaskDto>>.Success(
            ProjectTaskMapper.ToPagedDto(projectTask, _appConfig.Currency));
    }
}
