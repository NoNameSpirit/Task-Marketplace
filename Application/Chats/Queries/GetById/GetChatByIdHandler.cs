using Domain.Constants;
using Domain.Entities;
using Domain.Shared;
using Infrastructure.Repositories.Chats.Queries;
using MediatR;

namespace Application.Chats.Queries.GetById;

public class GetChatByIdHandler : IRequestHandler<GetChatByIdQuery, Result<Chat>>
{
    private readonly IChatQueryRepository _queryRepository;

    public GetChatByIdHandler(IChatQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result<Chat>> Handle(
        GetChatByIdQuery request,
        CancellationToken cancellationToken = default)
    {
        var chat = await _queryRepository.GetByIdAsync(request.ChatId, cancellationToken);

        if (chat is null)
        {
            return Result<Chat>.Failure(ErrorMessages.ChatNotFound);
        }

        return Result<Chat>.Success(chat);
    }
}
