using Application.Interfaces;
using Domain.Constants;
using Domain.Interfaces.Chats;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Chats.Commands.Delete;

public class DeleteChatHandler : IRequestHandler<DeleteChatCommand, Result>
{
    private readonly IChatCommandRepository _commandRepository;
    private readonly IChatQueryRepository _queryRepository;
    private readonly IProjectTaskQueryRepository _taskQueryRepository;
    private readonly ICurrentUser _currentUser;

    public DeleteChatHandler(
        IChatCommandRepository commandRepository,
        IChatQueryRepository queryRepository,
        IProjectTaskQueryRepository taskQueryRepository,
        ICurrentUser currentUser)
    {
        _commandRepository = commandRepository;
        _queryRepository = queryRepository;
        _taskQueryRepository = taskQueryRepository;
        _currentUser = currentUser;
    }

    public async Task<Result> Handle(
        DeleteChatCommand request,
        CancellationToken cancellationToken = default)
    {
        var chat = await _queryRepository.GetByIdAsync(
            request.ChatId,
            cancellationToken);

        if (chat is null)
        {
            return Result.Failure(
                ErrorMessages.ChatNotFound,
                ErrorType.NotFound);
        }

        var task = await _taskQueryRepository.GetByIdAsync(
            chat.ProjectTaskId,
            cancellationToken);

        if (task is null
            || task.CustomerId != _currentUser.Id)
        {
            return Result.Failure(
                ErrorMessages.Forbidden,
                ErrorType.Forbidden);
        }

        await _commandRepository.DeleteAsync(request.ChatId, cancellationToken);

        return Result.Success();
    }
}