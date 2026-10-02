using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.ProjectTasks.Queries.GetTasksByCustomer;

public record GetTasksByCustomerQuery(
    Guid CustomerId,
    int Page,
    int PageSize) : IRequest<Result<PagedResult<ProjectTaskDto>>>;
