using MediatR;
using Shared.Enums;
using System.Security.Claims;
using Task_Marketplace.Application.Handlers.ProjectTasks.Commands.Update;

namespace Web_Api.Controllers.Projects;

public record class UpdateProjectTaskRequestWithId(
    Guid Id,
    string Title,
    string Description,
    decimal Price,
    DateTimeOffset StartsAt,
    DateTimeOffset EndsAt);

public class UpdateEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<UpdateProjectTaskRequestWithId, object>
{
    public override void Configure()
    {
        Put("{id}");
        Group<ProjectTaskGroup>();
        Claims(ClaimTypes.NameIdentifier);
        Roles(nameof(UserRole.Customer));
    }

    public override async Task HandleAsync(
        UpdateProjectTaskRequestWithId request,
        CancellationToken cancellationToken = default)
    {
        var command = new UpdateProjectTaskCommand(
            request.Id,
            request.Title,
            request.Description,
            request.Price,
            request.StartsAt,
            request.EndsAt);

        var result = await _mediatr.Send(command, cancellationToken);

        if (await SendIfFailureAsync(result, cancellationToken))
        {
            return;
        }

        await Send.NoContentAsync(cancellationToken);
    }
}