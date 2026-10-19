using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Users.Commands.Delete;

[LogAction(UserActionType.UserDeleted, nameof(User))]
public record DeleteUserCommand(
    Guid TargetUserId) : IRequest<Result>;