using MediatR;
using Shared.Dtos;

namespace Application.Users.Commands.Update;

public record UpdateUserCommand(
    Guid UserId,
    string Name) : IRequest<Result>;
