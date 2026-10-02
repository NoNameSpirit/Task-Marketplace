using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Users.Commands.UnblockUser;

[LogAction(UserActionType.UserUnblocked, nameof(User))]
public record UnblockUserCommand(
    Guid TargetUserId,
    Guid CurrentUserId) : IRequest<Result>, IUserCommand
{
    public Guid UserId => CurrentUserId;
}