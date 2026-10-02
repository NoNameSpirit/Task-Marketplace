using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Users.Commands.BlockUser;

[LogAction(UserActionType.UserBlocked, nameof(User))]
public record BlockUserCommand(
    Guid TargetUserId,
    Guid CurrentUserId) : IRequest<Result>, IUserCommand
{
    public Guid UserId => CurrentUserId;
}