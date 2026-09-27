using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.Chats;
using Domain.Shared;
using MediatR;

namespace Application.Chats.Queries.GetByTaskId;

public class GetChatByTaskIdHandler : IRequestHandler<GetChatByTaskIdQuery, Result<Chat>>
{
    private readonly IChatQueryRepository _queryRepository;

    public GetChatByTaskIdHandler(IChatQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result<Chat>> Handle(
        GetChatByTaskIdQuery request,
        CancellationToken cancellationToken = default)
    {
        var chat = await _queryRepository.GetByTaskIdAsync(request.TaskId, cancellationToken);

        if (chat is null)
        {
            return Result<Chat>.Failure(ErrorMessages.ChatNotFound);
        }

        return Result<Chat>.Success(chat);
    }
}
