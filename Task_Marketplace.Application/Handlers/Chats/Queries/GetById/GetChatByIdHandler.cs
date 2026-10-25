using Application.Mappers;
using Domain.Constants;
using Domain.Interfaces.Chats;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;
using Shared.Enums;

namespace Task_Marketplace.Application.Handlers.Chats.Queries.GetById;

public class GetChatByIdHandler : IRequestHandler<GetChatByIdQuery, Result<ChatDto>>
{
    private readonly IChatQueryRepository _queryRepository;

    public GetChatByIdHandler(IChatQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result<ChatDto>> Handle(
        GetChatByIdQuery request,
        CancellationToken cancellationToken = default)
    {
        var chat = await _queryRepository.GetByIdAsync(request.ChatId, cancellationToken);

        if (chat is null)
        {
            return Result<ChatDto>.Failure(
                ErrorMessages.ChatNotFound,
                ErrorType.NotFound);
        }

        var userIds = chat.Messages.Select(m => m.UserId);
        var userNames = await _queryRepository.GetUserNamesAsync(userIds, cancellationToken);

        return Result<ChatDto>.Success(ChatMapper.ToDto(chat, userNames)!);
    }
}
