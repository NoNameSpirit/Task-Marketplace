using Application.Mappers;
using Domain.Constants;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos;
using Shared.Dtos.ProjectTasks;
using Shared.Enums;

namespace Application.ProjectTasks.Queries.GetTasksByCustomer;

public class GetTasksByCustomerHandler : IRequestHandler<GetTasksByCustomerQuery, Result<PagedResult<ProjectTaskDto>>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;

    public GetTasksByCustomerHandler(IProjectTaskQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
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

        return Result<PagedResult<ProjectTaskDto>>.Success(ProjectTaskMapper.ToPagedDto(projectTask));
    }
}
