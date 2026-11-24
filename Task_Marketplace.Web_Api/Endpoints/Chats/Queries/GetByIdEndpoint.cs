using MediatR;
using Shared.Dtos.Responses.Chats;
using System.Security.Claims;
using Task_Marketplace.Application.Handlers.Chats.Queries.GetById;
using Task_Marketplace.Shared.Dtos.Requests.Chats.Queries;

namespace Web_Api.Controllers.Chats;

public class GetByIdEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<GetChatByIdRequest, ChatDto>
{
    public override void Configure()
    {
        Get("{id}");
        Group<ChatGroup>();
        Claims(ClaimTypes.NameIdentifier);
    }

    public override async Task HandleAsync(
        GetChatByIdRequest request,
        CancellationToken cancellationToken = default)
    {
        var query = new GetChatByIdQuery(request.Id);

        var result = await _mediatr.Send(query, cancellationToken);

        if (await SendIfFailureAsync(result, cancellationToken))
        {
            return;
        }

        await Send.OkAsync(result.Value!, cancellationToken);
    }
}