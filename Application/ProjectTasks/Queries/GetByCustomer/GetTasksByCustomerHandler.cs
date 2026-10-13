using Application.Mappers;
using Domain.Config;
using Domain.Constants;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Microsoft.Extensions.Options;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;

namespace Application.ProjectTasks.Queries.GetTasksByCustomer;

public class GetTasksByCustomerHandler : IRequestHandler<GetTasksByCustomerQuery, Result<PagedResult<ProjectTaskDto>>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly AppConfig _appConfig;

    public GetTasksByCustomerHandler(
        IProjectTaskQueryRepository queryRepository,
        IOptions<AppConfig> appConfig)
    {
        _queryRepository = queryRepository;
        _appConfig = appConfig.Value;
    }

    public async Task<Result<PagedResult<ProjectTaskDto>>> Handle(
        GetTasksByCustomerQuery request,
        CancellationToken cancellationToken = default)
    {
        var projectTask = await _queryRepository.GetByCustomerIdAsync(
            request.CustomerId,
            request.Page,
            request.PageSize,
            cancellationToken);

        if (projectTask.TotalCount == CurrencyConstants.ZeroElements)
        {
            return Result<PagedResult<ProjectTaskDto>>.Failure(
                ErrorMessages.ProjectTaskByCustomerNotFound,
                ErrorType.NotFound);
        }

        return Result<PagedResult<ProjectTaskDto>>.Success(
            ProjectTaskMapper.ToPagedDto(
                projectTask,
                _appConfig.Currency));
    }
}
