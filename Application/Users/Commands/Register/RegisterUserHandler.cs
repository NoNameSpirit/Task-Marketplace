using Application.Services.Hasher;
using Application.Services.JwtGenerator;
using Application.Users.Commands.Login;
using Domain.Entities;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos;
using Shared.Enums;

namespace Application.Users.Commands.Register;

public class RegisterUserHandler : IRequestHandler<RegisterUserCommand, Result<string>>
{
    private readonly IUserCommandRepository _commandRepository;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IPasswordHasher _passwordHasher;

    public RegisterUserHandler(
        IUserCommandRepository commandRepository,
        IJwtTokenGenerator jwtTokenGenerator,
        IPasswordHasher passwordHasher)
    {
        _commandRepository = commandRepository;
        _jwtTokenGenerator = jwtTokenGenerator;
        _passwordHasher = passwordHasher;
    }

    public async Task<Result<string>> Handle(
        RegisterUserCommand request,
        CancellationToken cancellationToken = default)
    {
        var hashResult = _passwordHasher.Hash(request.Password);

        if (!hashResult.IsSuccess)
        {
            return Result<string>.Failure(
                hashResult.Message,
                ErrorType.Validation);
        }

        var userResult = User.Create(
            request.Name,
            hashResult.Value!,
            request.Role);

        if (!userResult.IsSuccess)
        {
            return Result<string>.Failure(
                userResult.Message,
                ErrorType.Validation);
        }

        await _commandRepository.AddAsync(userResult.Value!, cancellationToken);

        var token = _jwtTokenGenerator.GenerateToken(userResult.Value!);

        return Result<string>.Success(token);
    }
}
