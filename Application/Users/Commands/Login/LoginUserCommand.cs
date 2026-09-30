using MediatR;
using Shared.Dtos;

namespace Application.Users.Commands.Login;

public record LoginUserCommand(
    string Name,
    string Password) : IRequest<Result<string>>;