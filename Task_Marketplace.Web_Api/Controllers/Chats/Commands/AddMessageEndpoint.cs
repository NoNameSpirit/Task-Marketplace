using MediatR;
using System.Security.Claims;
using Task_Marketplace.Application.Handlers.Chats.Commands.AddMessage;
using Task_Marketplace.Shared.Dtos.Requests.Chats.Commands;

namespace Web_Api.Controllers.Chats;

public class AddMessageEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<AddMessageRequest, object>
{
    public override void Configure()
    {
        Post("{id}/messages");
        Group<ChatGroup>();
        Claims(ClaimTypes.NameIdentifier);
    }

    public override async Task HandleAsync(
        AddMessageRequest request,
        CancellationToken cancellationToken = default)
    {
        var command = new AddMessageCommand(request.Id, request.Text);

        var result = await _mediatr.Send(command, cancellationToken);

        if (await SendIfFailureAsync(result, cancellationToken))
        {
            return;
        }

        await Send.NoContentAsync(cancellationToken);
    }
}