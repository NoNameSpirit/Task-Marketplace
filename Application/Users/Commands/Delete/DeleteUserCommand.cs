using MediatR;
using Shared.Dtos.Responses;

namespace Application.Users.Commands.Delete;

public record DeleteUserCommand(
    Guid UserId) : IRequest<Result>;
