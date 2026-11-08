using MediatR;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;
using System.Security.Claims;
using Task_Marketplace.Application.Handlers.ProjectTasks.Queries.GetResponses;
using Task_Marketplace.Shared.Dtos.Requests.ProjectTasks.Queries;

namespace Web_Api.Controllers.Projects;

public class GetResponsesEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<GetByIdRequest, List<TaskResponseDto>>
{
    public override void Configure()
    {
        Get("{id}/responses");
        Group<ProjectTaskGroup>();
        Claims(ClaimTypes.NameIdentifier);
        Roles(nameof(UserRole.Customer));
    }

    public override async Task HandleAsync(
        GetByIdRequest request,
        CancellationToken cancellationToken = default)
    {
        var query = new GetTaskResponsesQuery(request.Id);

        var result = await _mediatr.Send(query, cancellationToken);

        if (await SendIfFailureAsync(result, cancellationToken))
        {
            return;
        }

        await Send.OkAsync(result.Value!, cancellationToken);
    }
}