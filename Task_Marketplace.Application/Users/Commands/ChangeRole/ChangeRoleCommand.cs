using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Users.Commands.ChangeRole;

[LogAction(UserActionType.UserRoleChanged, nameof(User))]
public record ChangeRoleCommand(
    Guid TargetUserId,
    UserRole NewRole) : IRequest<Result>;