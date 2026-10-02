using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Chats.Commands.Delete;

[LogAction(UserActionType.DeletedChat, nameof(Chat))]
public record DeleteChatCommand(
    Guid ChatId,
    Guid CurrentUserId) : IRequest<Result>, IUserCommand
{
    public Guid UserId => CurrentUserId;
}
