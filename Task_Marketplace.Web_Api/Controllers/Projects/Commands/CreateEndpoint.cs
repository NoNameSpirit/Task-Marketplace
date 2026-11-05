using MediatR;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;
using System.Security.Claims;
using Task_Marketplace.Application.Handlers.ProjectTasks.Commands.Create;
using Task_Marketplace.Shared.Dtos.Requests.ProjectTasks.Commands;

namespace Web_Api.Controllers.Projects;

public class CreateEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<CreateRequest, ProjectTaskDto>
{
    public override void Configure()
    {
        Post(string.Empty);
        Group<ProjectTaskGroup>();
        Claims(ClaimTypes.NameIdentifier);
        Roles(nameof(UserRole.Customer));
    }

    public override async Task HandleAsync(
        CreateRequest request,
        CancellationToken cancellationToken = default)
    {
        var command = new CreateProjectTaskCommand(
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

        await Send.CreatedAtAsync<GetByIdEndpoint>(
            new { id = result.Value!.Id },
            result.Value!,
            cancellation: cancellationToken);
    }
}