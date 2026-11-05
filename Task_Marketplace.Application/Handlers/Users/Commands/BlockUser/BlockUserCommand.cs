using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;
using Task_Marketplace.Application.Attributes;

namespace Task_Marketplace.Application.Handlers.Users.Commands.BlockUser;

[LogAction(UserActionType.UserBlocked, nameof(User))]
public record BlockUserCommand(
    Guid TargetUserId) : IRequest<Result>;