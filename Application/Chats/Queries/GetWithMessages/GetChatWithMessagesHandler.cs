using Application.Mappers;
using Domain.Constants;
using Domain.Interfaces.Chats;
using MediatR;
using Shared.Dtos;
using Shared.Dtos.Chats;
using Shared.Enums;

namespace Application.Chats.Queries.GetWithMessages;

public class GetChatWithMessagesHandler : IRequestHandler<GetChatWithMessagesQuery, Result<ChatDto>>
{
    private readonly IChatQueryRepository _queryRepository;

    public GetChatWithMessagesHandler(IChatQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result<ChatDto>> Handle(
        GetChatWithMessagesQuery request,
        CancellationToken cancellationToken = default)
    {
        var chat = await _queryRepository.GetByIdWithMessagesAsync(request.ChatId, cancellationToken);

        if (chat is null)
        {
            return Result<ChatDto>.Failure(
                ErrorMessages.ChatNotFound,
                ErrorType.NotFound);
        }

        return Result<ChatDto>.Success(ChatMapper.ToDto(chat));
    }
}