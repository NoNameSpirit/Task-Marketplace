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

namespace Task_Marketplace.Application.Handlers.ProjectTasks.Queries.GetByCustomer;

public class GetTasksByCustomerHandler : IRequestHandler<GetTasksByCustomerQuery, Result<PagedResult<ProjectTaskDto>>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly ICurrentUser _currentUser;
    private readonly AppConfig _appConfig;

    public GetTasksByCustomerHandler(
        IProjectTaskQueryRepository queryRepository,
        IOptions<AppConfig> appConfig,
        ICurrentUser currentUser)
    {
        _queryRepository = queryRepository;
        _appConfig = appConfig.Value;
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
