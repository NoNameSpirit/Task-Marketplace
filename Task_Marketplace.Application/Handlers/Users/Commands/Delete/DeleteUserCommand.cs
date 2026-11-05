using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;
using Task_Marketplace.Application.Attributes;

namespace Task_Marketplace.Application.Handlers.Users.Commands.Delete;

[LogAction(UserActionType.UserDeleted, nameof(User))]
public record DeleteUserCommand(
    Guid TargetUserId) : IRequest<Result>;