using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.ProjectTasks;
using Domain.Shared;
using MediatR;

namespace Application.ProjectTasks.Queries.GetTasksByCustomer;

public class GetTasksByCustomerHandler : IRequestHandler<GetTasksByCustomerQuery, Result<PagedResult<ProjectTask>>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;

    public GetTasksByCustomerHandler(IProjectTaskQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result<PagedResult<ProjectTask>>> Handle(
        GetTasksByCustomerQuery request,
        CancellationToken cancellationToken = default)
    {
        var projectTask = await _queryRepository.GetByCustomerIdAsync(request.CustomerId, request.Page, request.PageSize, cancellationToken);

        if (projectTask.TotalCount == CurrencyConstants.ZeroElements)
        {
            return Result<PagedResult<ProjectTask>>.Failure(ErrorMessages.ProjectTaskByCustomerNotFound);
        }

        return Result<PagedResult<ProjectTask>>.Success(projectTask);
    }
}
