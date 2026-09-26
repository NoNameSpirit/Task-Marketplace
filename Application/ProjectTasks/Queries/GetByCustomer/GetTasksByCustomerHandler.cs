using Domain.Entities;
using Domain.Shared;
using Infrastructure.Repositories.ProjectTasks.Queries;
using MediatR;

namespace Application.ProjectTasks.Queries.GetTasksByCustomer;

public class GetTasksByCustomerHandler : IRequestHandler<GetTasksByCustomerQuery, PagedResult<ProjectTask>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;

    public GetTasksByCustomerHandler(IProjectTaskQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<PagedResult<ProjectTask>> Handle(
        GetTasksByCustomerQuery request,
        CancellationToken cancellationToken = default)
    {
        return await _queryRepository.GetByCustomerIdAsync(request.CustomerId, request.Page, request.PageSize, cancellationToken);
    }
}
