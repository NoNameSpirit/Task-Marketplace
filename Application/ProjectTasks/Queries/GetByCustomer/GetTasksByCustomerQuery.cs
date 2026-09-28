using MediatR;
using Shared.Dtos;
using Shared.Dtos.ProjectTasks;

namespace Application.ProjectTasks.Queries.GetTasksByCustomer;

public record GetTasksByCustomerQuery(
    Guid CustomerId,
    int Page,
    int PageSize) : IRequest<Result<PagedResult<ProjectTaskDto>>>;
