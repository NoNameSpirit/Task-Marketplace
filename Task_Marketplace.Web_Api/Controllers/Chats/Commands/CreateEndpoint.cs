using MediatR;
using Shared.Dtos.Responses.Chats;
using System.Security.Claims;
using Task_Marketplace.Application.Handlers.Chats.Commands.Create;
using Task_Marketplace.Shared.Dtos.Requests.Chats.Commands;

namespace Web_Api.Controllers.Chats;

public class CreateEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<CreateChatRequest, ChatDto>
{
    public override void Configure()
    {
        Post(string.Empty);
        Group<ChatGroup>();
        Claims(ClaimTypes.NameIdentifier);
    }

    public override async Task HandleAsync(
        CreateChatRequest request,
        CancellationToken cancellationToken = default)
    {
        var command = new CreateChatCommand(request.ProjectTaskId);

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