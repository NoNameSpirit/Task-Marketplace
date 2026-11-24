using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using System.Security.Claims;
using Task_Marketplace.Application.Handlers.ProjectTasks.Queries.GetPublished;
using Task_Marketplace.Shared.Dtos.Requests.ProjectTasks.Queries;

namespace Web_Api.Controllers.Projects;

public class GetPublishedEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<GetPublishedRequest, PagedResult<ProjectTaskDto>>
{
    public override void Configure()
    {
        Get("published");
        Group<ProjectTaskGroup>();
        Claims(ClaimTypes.NameIdentifier);
    }

    public override async Task HandleAsync(
        GetPublishedRequest request,
        CancellationToken cancellationToken = default)
    {
        var query = new GetPublishedTasksQuery(request.Page, request.PageSize);

        var result = await _mediatr.Send(query, cancellationToken);

        if (await SendIfFailureAsync(result, cancellationToken))
        {
            return;
        }

        await Send.OkAsync(result.Value!, cancellationToken);
    }
}