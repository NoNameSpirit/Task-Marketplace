using MediatR;
using Shared.Dtos;

namespace Application.Users.Commands.Delete;

public record DeleteUserCommand(
    Guid UserId) : IRequest<Result>;
