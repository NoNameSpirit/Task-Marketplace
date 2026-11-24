using MediatR;
using Shared.Enums;
using System.Security.Claims;
using Task_Marketplace.Application.Handlers.Users.Commands.ChangeRole;
using Task_Marketplace.Shared.Dtos.Requests.Users.Commands;

namespace Web_Api.Controllers.Users;

public class ChangeRoleEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<ChangeRoleUserRequest, object>
{
    public override void Configure()
    {
        Patch("{id}/role");
        Group<UserGroup>();
        Claims(ClaimTypes.NameIdentifier);
        Roles(nameof(UserRole.Admin));
    }

    public override async Task HandleAsync(
        ChangeRoleUserRequest request,
        CancellationToken cancellationToken = default)
    {
        var command = new ChangeRoleCommand(request.Id, request.NewRole);

        var result = await _mediatr.Send(command, cancellationToken);

        if (await SendIfFailureAsync(result, cancellationToken))
        {
            return;
        }

        await Send.NoContentAsync(cancellationToken);
    }
}