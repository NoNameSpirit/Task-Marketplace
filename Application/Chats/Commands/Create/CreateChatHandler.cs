using Application.Interfaces;
using Application.Mappers;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.Chats;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;
using Shared.Enums;

namespace Application.Chats.Commands.Create;

public class CreateChatHandler : IRequestHandler<CreateChatCommand, Result<ChatDto>>
{
    private readonly IChatCommandRepository _commandRepository;
    private readonly IChatQueryRepository _queryRepository;
    private readonly IProjectTaskQueryRepository _taskQueryRepository;
    private readonly ICurrentUser _currentUser;

    public CreateChatHandler(
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

    public async Task<Result<ChatDto>> Handle(
        CreateChatCommand request,
        CancellationToken cancellationToken = default)
    {
        var task = await _taskQueryRepository.GetByIdAsync(request.ProjectTaskId, cancellationToken);

        if (task is null || (task.CustomerId != _currentUser.Id && task.ExecutorId != _currentUser.Id))
        {
            return Result<ChatDto>.Failure(
                ErrorMessages.Forbidden,
                ErrorType.Forbidden);
        }

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

        var dto = ChatMapper.ToDto(result.Value!, new Dictionary<Guid, string>());

        return Result<ChatDto>.Success(dto);
    }
}