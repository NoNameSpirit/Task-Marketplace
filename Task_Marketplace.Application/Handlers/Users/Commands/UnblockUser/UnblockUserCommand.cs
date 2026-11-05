using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Task_Marketplace.Application.Handlers.Users.Commands.UnblockUser;

[LogAction(UserActionType.UserUnblocked, nameof(User))]
public record UnblockUserCommand(
    Guid TargetUserId) : IRequest<Result>;