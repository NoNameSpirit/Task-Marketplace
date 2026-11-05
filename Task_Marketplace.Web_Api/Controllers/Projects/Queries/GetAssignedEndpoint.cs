using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using System.Security.Claims;
using Task_Marketplace.Application.Handlers.ProjectTasks.Queries.GetAssigned;
using Task_Marketplace.Shared.Dtos.Requests.ProjectTasks.Queries;

namespace Web_Api.Controllers.Projects;

public class GetAssignedEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<GetAssignedRequest, PagedResult<ProjectTaskDto>>
{
    public override void Configure()
    {
        Get("assigned/{executorId}");
        Group<ProjectTaskGroup>();
        Claims(ClaimTypes.NameIdentifier);
    }

    public override async Task HandleAsync(
        GetAssignedRequest request,
        CancellationToken cancellationToken = default)
    {
        var query = new GetAssignedTasksQuery(
            request.ExecutorId,
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