using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using Shared.Enums;

namespace Application.Users.Commands.Login;

public record RegisterUserCommand(
    string Name,
    string Password,
    UserRole Role) : IRequest<Result<AuthDto>>;