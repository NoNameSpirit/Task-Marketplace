using MediatR;
using Shared.Enums;
using System.Security.Claims;
using Task_Marketplace.Application.Handlers.ProjectTasks.Commands.MarkAsDone;

namespace Web_Api.Controllers.Projects;

public record class MarkAsDoneProjectTaskRequestWithId(
    Guid Id,
    decimal? Rating);

public class MarkAsDoneEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<MarkAsDoneProjectTaskRequestWithId, object>
{
    public override void Configure()
    {
        Post("{id}/mark-as-done");
        Group<ProjectTaskGroup>();
        Claims(ClaimTypes.NameIdentifier);
        Roles(nameof(UserRole.Customer));
    }

    public override async Task HandleAsync(
        MarkAsDoneProjectTaskRequestWithId request,
        CancellationToken cancellationToken = default)
    {
        var command = new MarkAsDoneCommand(request.Id, request.Rating);

        var result = await _mediatr.Send(command, cancellationToken);

        if (await SendIfFailureAsync(result, cancellationToken))
        {
            return;
        }

        await Send.NoContentAsync(cancellationToken);
    }
}