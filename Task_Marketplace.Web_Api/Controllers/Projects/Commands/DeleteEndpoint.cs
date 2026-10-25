using MediatR;
using Shared.Enums;
using System.Security.Claims;
using Task_Marketplace.Application.Handlers.ProjectTasks.Commands.Delete;
using Task_Marketplace.Shared.Dtos.Requests.ProjectTasks.Queries;

namespace Web_Api.Controllers.Projects;

public class DeleteEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<GetByIdRequest, object>
{
    public override void Configure()
    {
        Delete("{id}");
        Group<ProjectTaskGroup>();
        Claims(ClaimTypes.NameIdentifier);
        Roles(nameof(UserRole.Customer));
    }

    public override async Task HandleAsync(
        GetByIdRequest request,
        CancellationToken cancellationToken = default)
    {
        var command = new DeleteProjectTaskCommand(request.Id);

        var result = await _mediatr.Send(command, cancellationToken);

        if (await SendIfFailureAsync(result, cancellationToken))
        {
            return;
        }

        await Send.NoContentAsync(cancellationToken);
    }
}