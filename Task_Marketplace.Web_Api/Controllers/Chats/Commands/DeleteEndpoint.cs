using MediatR;
using Shared.Enums;
using System.Security.Claims;
using Task_Marketplace.Application.Handlers.Chats.Commands.Delete;
using Task_Marketplace.Shared.Dtos.Requests.Chats.Queries;

namespace Web_Api.Controllers.Chats;

public class DeleteEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<GetChatByIdRequest, object>
{
    public override void Configure()
    {
        Delete("{id}");
        Group<ChatGroup>();
        Claims(ClaimTypes.NameIdentifier);
        Roles(nameof(UserRole.Customer), nameof(UserRole.Admin));
    }

    public override async Task HandleAsync(
        GetChatByIdRequest request,
        CancellationToken cancellationToken = default)
    {
        var command = new DeleteChatCommand(request.Id);

        var result = await _mediatr.Send(command, cancellationToken);

        if (await SendIfFailureAsync(result, cancellationToken))
        {
            return;
        }

        await Send.NoContentAsync(cancellationToken);
    }
}