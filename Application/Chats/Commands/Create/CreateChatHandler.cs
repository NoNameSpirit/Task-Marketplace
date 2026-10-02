using Application.Mappers;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.Chats;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;
using Shared.Enums;

namespace Application.Chats.Commands.Create;

public class CreateChatHandler : IRequestHandler<CreateChatCommand, Result<ChatDto>>
{
    private readonly IChatCommandRepository _commandRepository;
    private readonly IChatQueryRepository _queryRepository;

    public CreateChatHandler(
        IChatCommandRepository commandRepository,
        IChatQueryRepository queryRepository)
    {
        _commandRepository = commandRepository;
        _queryRepository = queryRepository;
    }

    public async Task<Result<ChatDto>> Handle(
        CreateChatCommand request,
        CancellationToken cancellationToken = default)
    {
        var existingChat = await _queryRepository.GetByTaskIdAsync(request.ProjectTaskId, cancellationToken);

        if (existingChat is not null)
        {
            return Result<ChatDto>.Failure(
                ErrorMessages.ChatAlreadyExists,
                ErrorType.Conflict);
        }

        var result = Chat.Create(request.ProjectTaskId);

        if (!result.IsSuccess)
        {
            return Result<ChatDto>.Failure(
                result.Message,
                ErrorType.Validation);
        }

        await _commandRepository.AddAsync(result.Value!, cancellationToken);

        return Result<ChatDto>.Success(ChatMapper.ToDto(result.Value!));
    }
}
