using Domain.Entities;
using Domain.Shared;
using MediatR;

namespace Application.ProjectTasks.Queries.GetTasksByCustomer;

public record GetTasksByCustomerQuery(
    Guid CustomerId,
    int Page,
    int PageSize) : IRequest<Result<PagedResult<ProjectTask>>>;
