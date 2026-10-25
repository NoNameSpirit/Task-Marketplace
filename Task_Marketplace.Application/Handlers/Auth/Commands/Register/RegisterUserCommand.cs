using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using Shared.Enums;

namespace Task_Marketplace.Application.Handlers.Auth.Commands.Register;

public record RegisterUserCommand(
    string Name,
    string Password,
    UserRole Role) : IRequest<Result<AuthDto>>;