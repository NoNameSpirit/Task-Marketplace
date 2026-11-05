using MediatR;
using Shared.Dtos.Responses.Chats;
using System.Security.Claims;
using Task_Marketplace.Application.Handlers.Chats.Queries.GetByTaskId;
using Task_Marketplace.Shared.Dtos.Requests.Chats.Queries;

namespace Web_Api.Controllers.Chats;

public class GetByTaskIdEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<GetChatByTaskIdRequest, ChatDto>
{
    public override void Configure()
    {
        Get("task/{id}");
        Group<ChatGroup>();
        Claims(ClaimTypes.NameIdentifier);
    }

    public override async Task HandleAsync(
        GetChatByTaskIdRequest request,
        CancellationToken cancellationToken = default)
    {
        var query = new GetChatByTaskIdQuery(request.Id);

        var result = await _mediatr.Send(query, cancellationToken);

        if (await SendIfFailureAsync(result, cancellationToken))
        {
            return;
        }

        await Send.OkAsync(result.Value!, cancellationToken);
    }
}