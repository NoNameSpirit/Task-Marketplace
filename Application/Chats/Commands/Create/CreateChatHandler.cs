using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.Chats;
using MediatR;
using Shared.Dtos;

namespace Application.Chats.Commands.Create;

public class CreateChatHandler : IRequestHandler<CreateChatCommand, Result<Chat>>
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

    public async Task<Result<Chat>> Handle(
        CreateChatCommand request,
        CancellationToken cancellationToken = default)
    {
        var existingChat = await _queryRepository.GetByTaskIdAsync(request.ProjectTaskId, cancellationToken);

        if (existingChat is not null)
        {
            return Result<Chat>.Failure(ErrorMessages.ChatAlreadyExists);
        }

        var result = Chat.Create(request.ProjectTaskId);

        if (!result.IsSuccess)
        {
            return Result<Chat>.Failure(result.Message);
        }

        await _commandRepository.AddAsync(result.Value!, cancellationToken);

        return Result<Chat>.Success(result.Value!);
    }
}
