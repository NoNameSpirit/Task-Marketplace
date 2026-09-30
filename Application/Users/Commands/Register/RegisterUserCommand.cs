using MediatR;
using Shared.Dtos;
using Shared.Enums;

namespace Application.Users.Commands.Login;

public record RegisterUserCommand(
    string Name,
    string Password,
    UserRole Role) : IRequest<Result<string>>;