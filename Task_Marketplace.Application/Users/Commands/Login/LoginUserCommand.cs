using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;

namespace Application.Users.Commands.Login;

public record LoginUserCommand(
    string Name,
    string Password) : IRequest<Result<AuthDto>>;