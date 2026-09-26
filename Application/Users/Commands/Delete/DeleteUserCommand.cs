using Domain.Shared;
using MediatR;

namespace Application.Users.Commands.Delete;

public record DeleteUserCommand(
    Guid UserId) : IRequest<Result>;
