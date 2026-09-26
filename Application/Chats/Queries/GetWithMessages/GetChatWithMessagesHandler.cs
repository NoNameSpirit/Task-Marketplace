using Domain.Entities;
using Infrastructure.Repositories.Chats.Queries;
using MediatR;

namespace Application.Chats.Queries.GetWithMessages;

public class GetChatWithMessagesHandler : IRequestHandler<GetChatWithMessagesQuery, Chat?>
{
    private readonly IChatQueryRepository _queryRepository;

    public GetChatWithMessagesHandler(IChatQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Chat?> Handle(
        GetChatWithMessagesQuery request,
        CancellationToken cancellationToken = default)
    {
        return await _queryRepository.GetByIdWithMessagesAsync(request.ChatId, cancellationToken);
    }
}