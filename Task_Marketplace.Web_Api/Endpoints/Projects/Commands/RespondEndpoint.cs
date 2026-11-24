using MediatR;
using Shared.Enums;
using System.Security.Claims;
using Task_Marketplace.Application.Handlers.ProjectTasks.Commands.RespondToTask;
using Task_Marketplace.Shared.Dtos.Requests.ProjectTasks.Queries;

namespace Web_Api.Controllers.Projects;

public class RespondEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<GetByIdRequest, object>
{
    public override void Configure()
    {
        Post("{id}/respond");
        Group<ProjectTaskGroup>();
        Claims(ClaimTypes.NameIdentifier);
        Roles(nameof(UserRole.Executor));
    }

    public override async Task HandleAsync(
        GetByIdRequest request,
        CancellationToken cancellationToken = default)
    {
        var command = new RespondToTaskCommand(request.Id);

        var result = await _mediatr.Send(command, cancellationToken);

        if (await SendIfFailureAsync(result, cancellationToken))
        {
            return;
        }

        await Send.NoContentAsync(cancellationToken);
    }
}