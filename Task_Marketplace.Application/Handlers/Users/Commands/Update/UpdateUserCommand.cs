using MediatR;
using Shared.Dtos.Responses;

namespace Task_Marketplace.Application.Handlers.Users.Commands.Update;

public record UpdateUserCommand(
    Guid TargetUserId,
    string Name) : IRequest<Result>;