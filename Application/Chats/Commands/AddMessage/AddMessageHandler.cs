using Domain.Constants;
using Domain.Interfaces;
using Domain.Interfaces.Chats;
using Domain.Interfaces.ProjectTasks;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Chats.Commands.AddMessage;

public class AddMessageHandler : IRequestHandler<AddMessageCommand, Result>
{
    private readonly IChatQueryRepository _queryRepository;
    private readonly IChatCommandRepository _commandRepository;
    private readonly IUserQueryRepository _userQueryRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IProjectTaskQueryRepository _taskQueryRepository;

    public AddMessageHandler(
        IChatQueryRepository queryRepository,
        IChatCommandRepository commandRepository,
        IUserQueryRepository userQueryRepository,
        IUnitOfWork unitOfWork,
        IProjectTaskQueryRepository taskQueryRepository)
    {
        _queryRepository = queryRepository;
        _commandRepository = commandRepository;
        _userQueryRepository = userQueryRepository;
        _unitOfWork = unitOfWork;
        _taskQueryRepository = taskQueryRepository;
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
            || (task.CustomerId != request.SenderId
            && task.ExecutorId != request.SenderId))
        {
            return Result.Failure(
                ErrorMessages.Forbidden,
                ErrorType.Forbidden);
        }

        var sender = await _userQueryRepository.GetByIdAsync(
            request.SenderId,
            cancellationToken);

        if (sender is null)
        {
            return Result.Failure(
                ErrorMessages.UserNotFound,
                ErrorType.NotFound);
        }

        var result = chat.AddMessage(request.Text, request.SenderId);

        if (!result.IsSuccess)
        {
            return Result.Failure(
                result.Message,
                ErrorType.Validation);
        }

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}