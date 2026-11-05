using MediatR;
using Shared.Enums;
using System.Security.Claims;
using Task_Marketplace.Application.Handlers.ProjectTasks.Commands.AssignExecutor;

namespace Web_Api.Controllers.Projects;

public record class AssignExecutorProjectTaskRequestWithId(
    Guid Id,
    Guid ExecutorId);

public class AssignEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<AssignExecutorProjectTaskRequestWithId, object>
{
    public override void Configure()
    {
        Post("{id}/assign");
        Group<ProjectTaskGroup>();
        Claims(ClaimTypes.NameIdentifier);
        Roles(nameof(UserRole.Customer));
    }

    public override async Task HandleAsync(
        AssignExecutorProjectTaskRequestWithId request,
        CancellationToken cancellationToken = default)
    {
        var command = new AssignExecutorCommand(request.Id, request.ExecutorId);

        var result = await _mediatr.Send(command, cancellationToken);

        if (await SendIfFailureAsync(result, cancellationToken))
        {
            return;
        }

        await Send.NoContentAsync(cancellationToken);
    }
}