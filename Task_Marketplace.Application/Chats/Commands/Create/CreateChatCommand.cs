using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;
using Shared.Enums;

namespace Application.Chats.Commands.Create;

[LogAction(UserActionType.CreatedChat, nameof(Chat))]
public record CreateChatCommand(
    Guid ProjectTaskId) : IRequest<Result<ChatDto>>;