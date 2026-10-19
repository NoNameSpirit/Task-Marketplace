using Domain.Constants;
using Domain.Interfaces;
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
    private readonly IUnitOfWork _unitOfWork;

    public DeleteChatHandler(
        IChatCommandRepository commandRepository,
        IChatQueryRepository queryRepository,
        IProjectTaskQueryRepository taskQueryRepository,
        IUnitOfWork unitOfWork)
    {
        _commandRepository = commandRepository;
        _queryRepository = queryRepository;
        _taskQueryRepository = taskQueryRepository;
        _unitOfWork = unitOfWork;
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
            || task.CustomerId != request.CurrentUserId)
        {
            return Result.Failure(
                ErrorMessages.Forbidden,
                ErrorType.Forbidden);
        }

        await _commandRepository.DeleteAsync(request.ChatId, cancellationToken);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}