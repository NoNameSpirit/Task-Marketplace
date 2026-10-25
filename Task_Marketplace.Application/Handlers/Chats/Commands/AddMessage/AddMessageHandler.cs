using Application.Interfaces;
using Domain.Constants;
using Domain.Interfaces.Chats;
using Domain.Interfaces.ProjectTasks;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Task_Marketplace.Application.Handlers.Chats.Commands.AddMessage;

public class AddMessageHandler : IRequestHandler<AddMessageCommand, Result>
{
    private readonly IChatQueryRepository _queryRepository;
    private readonly IUserQueryRepository _userQueryRepository;
    private readonly IProjectTaskQueryRepository _taskQueryRepository;
    private readonly ICurrentUser _currentUser;

    public AddMessageHandler(
        IChatQueryRepository queryRepository,
        IUserQueryRepository userQueryRepository,
        IProjectTaskQueryRepository taskQueryRepository,
        ICurrentUser currentUser)
    {
        _queryRepository = queryRepository;
        _userQueryRepository = userQueryRepository;
        _taskQueryRepository = taskQueryRepository;
        _currentUser = currentUser;
    }

    public async Task<Result> Handle(
        AddMessageCommand request,
        CancellationToken cancellationToken = default)
    {
        var chat = await _queryRepository.GetTrackedByIdAsync(
            request.ChatId,
            cancellationToken);

        if (chat is null)
        {
            return Result.Failure(
                ErrorMessages.ChatNotFound,
                ErrorType.NotFound);
        }

        var task = await _taskQueryRepository.GetByIdAsync(chat.ProjectTaskId, cancellationToken);
        if (task is null
            || (task.CustomerId != _currentUser.Id
            && task.ExecutorId != _currentUser.Id))
        {
            return Result.Failure(
                ErrorMessages.Forbidden,
                ErrorType.Forbidden);
        }

        var sender = await _userQueryRepository.GetByIdAsync(
            _currentUser.Id,
            cancellationToken);

        if (sender is null)
        {
            return Result.Failure(
                ErrorMessages.UserNotFound,
                ErrorType.NotFound);
        }

        var result = chat.AddMessage(request.Text, _currentUser.Id);

        if (!result.IsSuccess)
        {
            return Result.Failure(
                result.Message,
                ErrorType.Validation);
        }

        return Result.Success();
    }
}