using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;

namespace Task_Marketplace.Application.Handlers.Auth.Commands.Login;

public record LoginUserCommand(
    string Name,
    string Password) : IRequest<Result<AuthDto>>;