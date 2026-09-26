using Domain.Entities;
using Infrastructure.Repositories.Chats.Queries;
using MediatR;

namespace Application.Chats.Queries.GetById;

public class GetChatByIdHandler : IRequestHandler<GetChatByIdQuery, Chat?>
{
    private readonly IChatQueryRepository _queryRepository;

    public GetChatByIdHandler(IChatQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Chat?> Handle(
        GetChatByIdQuery request,
        CancellationToken cancellationToken = default)
    {
        return await _queryRepository.GetByIdAsync(request.ChatId, cancellationToken);
    }
}
