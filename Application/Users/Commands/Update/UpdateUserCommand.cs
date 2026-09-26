using Domain.Shared;
using MediatR;

namespace Application.Users.Commands.Update;

public record UpdateUserCommand(
    Guid UserId,
    string Name) : IRequest<Result>;
