using MediatR;
using Shared.Enums;
using System.Security.Claims;
using Task_Marketplace.Application.Handlers.Users.Commands.BlockUser;
using Task_Marketplace.Shared.Dtos.Requests.Users.Queries;

namespace Web_Api.Controllers.Users;

public class BlockEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<GetUserByIdRequest, object>
{
    public override void Configure()
    {
        Post("{id}/block");
        Group<UserGroup>();
        Claims(ClaimTypes.NameIdentifier);
        Roles(nameof(UserRole.Admin));
    }

    public override async Task HandleAsync(
        GetUserByIdRequest request,
        CancellationToken cancellationToken = default)
    {
        var command = new BlockUserCommand(request.Id);

        var result = await _mediatr.Send(command, cancellationToken);

        if (await SendIfFailureAsync(result, cancellationToken))
        {
            return;
        }

        await Send.NoContentAsync(cancellationToken);
    }
}