using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;
using Task_Marketplace.Application.Attributes;

namespace Task_Marketplace.Application.Handlers.Users.Commands.ChangeRole;

[LogAction(UserActionType.UserRoleChanged, nameof(User))]
public record ChangeRoleCommand(
    Guid TargetUserId,
    UserRole NewRole) : IRequest<Result>;