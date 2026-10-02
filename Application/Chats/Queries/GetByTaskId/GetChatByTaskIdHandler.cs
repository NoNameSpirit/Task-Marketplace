using Application.Mappers;
using Domain.Constants;
using Domain.Interfaces.Chats;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;
using Shared.Enums;

namespace Application.Chats.Queries.GetByTaskId;

public class GetChatByTaskIdHandler : IRequestHandler<GetChatByTaskIdQuery, Result<ChatDto>>
{
    private readonly IChatQueryRepository _queryRepository;

    public GetChatByTaskIdHandler(IChatQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result<ChatDto>> Handle(
        GetChatByTaskIdQuery request,
        CancellationToken cancellationToken = default)
    {
        var chat = await _queryRepository.GetByTaskIdAsync(request.TaskId, cancellationToken);

        if (chat is null)
        {
            return Result<ChatDto>.Failure(
                ErrorMessages.ChatNotFound,
                ErrorType.NotFound);
        }

        return Result<ChatDto>.Success(ChatMapper.ToDto(chat)!);
    }
}
