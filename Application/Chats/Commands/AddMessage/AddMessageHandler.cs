using Domain.Constants;
using Domain.Interfaces.Chats;
using Domain.Shared;
using MediatR;

namespace Application.Chats.Commands.AddMessage;

public class AddMessageHandler : IRequestHandler<AddMessageCommand, Result>
{
    private readonly IChatQueryRepository _queryRepository;
    private readonly IChatCommandRepository _commandRepository;

    public AddMessageHandler(
        IChatQueryRepository queryRepository,
        IChatCommandRepository commandRepository)
    {
        _queryRepository = queryRepository;
        _commandRepository = commandRepository;
    }

    public async Task<Result> Handle(
        AddMessageCommand request,
        CancellationToken cancellationToken = default)
    {
        var chat = await _queryRepository.GetByIdAsync(request.ChatId, cancellationToken);

        if (chat is null)
        {
            return Result.Failure(ErrorMessages.ChatNotFound);
        }

        var result = chat.AddMessage(request.Text, request.SenderId);

        if (!result.IsSuccess)
        {
            return Result.Failure(result.Message);
        }

        await _commandRepository.UpdateAsync(chat, cancellationToken);

        return Result.Success();
    }
}