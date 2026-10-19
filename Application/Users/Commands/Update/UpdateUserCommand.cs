using MediatR;
using Shared.Dtos.Responses;

namespace Application.Users.Commands.Update;

public record UpdateUserCommand(
    Guid TargetUserId,
    string Name) : IRequest<Result>;