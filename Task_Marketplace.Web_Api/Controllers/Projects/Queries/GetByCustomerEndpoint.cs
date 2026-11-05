using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using System.Security.Claims;
using Task_Marketplace.Application.Handlers.ProjectTasks.Queries.GetByCustomer;
using Task_Marketplace.Shared.Dtos.Requests.ProjectTasks.Queries;

namespace Web_Api.Controllers.Projects;

public class GetByCustomerEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<GetByCustomerRequest, PagedResult<ProjectTaskDto>>
{
    public override void Configure()
    {
        Get("customer/{customerId}");
        Group<ProjectTaskGroup>();
        Claims(ClaimTypes.NameIdentifier);
    }

    public override async Task HandleAsync(
        GetByCustomerRequest request,
        CancellationToken cancellationToken = default)
    {
        var query = new GetTasksByCustomerQuery(
            request.CustomerId,
            request.Page,
            request.PageSize);

        var result = await _mediatr.Send(query, cancellationToken);

        if (await SendIfFailureAsync(result, cancellationToken))
        {
            return;
        }

        await Send.OkAsync(result.Value!, cancellationToken);
    }
}