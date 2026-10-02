using Domain.Interfaces.Chats;
using MediatR;
using Shared.Dtos.Responses;

namespace Application.Chats.Commands.Delete;

public class DeleteChatHandler : IRequestHandler<DeleteChatCommand, Result>
{
    private readonly IChatCommandRepository _commandRepository;

    public DeleteChatHandler(IChatCommandRepository commandRepository)
    {
        _commandRepository = commandRepository;
    }

    public async Task<Result> Handle(
        DeleteChatCommand request,
        CancellationToken cancellationToken = default)
    {
        await _commandRepository.DeleteAsync(request.ChatId, cancellationToken);

        return Result.Success();
    }
}