using Application.Mappers;
using Domain.Constants;
using Domain.Interfaces.Chats;
using MediatR;
using Shared.Dtos;
using Shared.Dtos.Chats;

namespace Application.Chats.Queries.GetById;

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
            return Result<ChatDto>.Failure(ErrorMessages.ChatNotFound);
        }

        return Result<ChatDto>.Success(ChatMapper.ToDto(chat));
    }
}
