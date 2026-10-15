using Application.Mappers;
using Domain.Constants;
using Domain.Interfaces.Chats;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;
using Shared.Enums;

namespace Application.Chats.Queries.GetByTaskId;

public class GetChatByTaskIdHandler : IRequestHandler<GetChatByTaskIdQuery, Result<ChatDto>>
{
    private readonly IChatQueryRepository _queryRepository;
    private readonly IProjectTaskQueryRepository _taskQueryRepository;

    public GetChatByTaskIdHandler(
        IChatQueryRepository queryRepository,
        IProjectTaskQueryRepository taskQueryRepository)
    {
        _queryRepository = queryRepository;
        _taskQueryRepository = taskQueryRepository;
    }

    public async Task<Result<ChatDto>> Handle(
        GetChatByTaskIdQuery request,
        CancellationToken cancellationToken = default)
    {
        var task = await _taskQueryRepository.GetByIdAsync(
            request.TaskId,
            cancellationToken);

        if (task is null)
        {
            return Result<ChatDto>.Failure(
                ErrorMessages.ProjectTaskNotFound,
                ErrorType.NotFound);
        }

        if (task.CustomerId != request.CurrentUserId
            && task.ExecutorId != request.CurrentUserId)
        {
            return Result<ChatDto>.Failure(
                ErrorMessages.Forbidden,
                ErrorType.Forbidden);
        }

        var chat = await _queryRepository.GetByTaskIdAsync(
            request.TaskId,
            cancellationToken);

        if (chat is null)
        {
            return Result<ChatDto>.Failure(
                ErrorMessages.ChatNotFound,
                ErrorType.NotFound);
        }

        var userIds = chat.Messages.Select(m => m.UserId);
        var userNames = await _queryRepository.GetUserNamesAsync(
            userIds,
            cancellationToken);

        return Result<ChatDto>.Success(ChatMapper.ToDto(chat, userNames));
    }
}
