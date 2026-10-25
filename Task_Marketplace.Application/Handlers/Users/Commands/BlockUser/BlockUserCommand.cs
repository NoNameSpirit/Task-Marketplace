using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Task_Marketplace.Application.Handlers.Users.Commands.BlockUser;

[LogAction(UserActionType.UserBlocked, nameof(User))]
public record BlockUserCommand(
    Guid TargetUserId) : IRequest<Result>;