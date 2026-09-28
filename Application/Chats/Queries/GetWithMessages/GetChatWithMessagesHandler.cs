using Application.Mappers;
using Domain.Interfaces.Chats;
using MediatR;
using Shared.Dtos.Chats;

namespace Application.Chats.Queries.GetWithMessages;

public class GetChatWithMessagesHandler : IRequestHandler<GetChatWithMessagesQuery, ChatDto?>
{
    private readonly IChatQueryRepository _queryRepository;

    public GetChatWithMessagesHandler(IChatQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<ChatDto?> Handle(
        GetChatWithMessagesQuery request,
        CancellationToken cancellationToken = default)
    {
        var chat = await _queryRepository.GetByIdWithMessagesAsync(request.ChatId, cancellationToken);

        return ChatMapper.ToDto(chat);
    }
}