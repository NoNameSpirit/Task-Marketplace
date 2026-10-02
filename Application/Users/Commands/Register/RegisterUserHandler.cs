using Application.Services.Hasher;
using Application.Services.JwtGenerator;
using Application.Users.Commands.Login;
using Domain.Entities;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using Shared.Enums;

namespace Application.Users.Commands.Register;

public class RegisterUserHandler : IRequestHandler<RegisterUserCommand, Result<AuthDto>>
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

    public async Task<Result<AuthDto>> Handle(
        RegisterUserCommand request,
        CancellationToken cancellationToken = default)
    {
        var hashResult = _passwordHasher.Hash(request.Password);

        if (!hashResult.IsSuccess)
        {
            return Result<AuthDto>.Failure(
                hashResult.Message,
                ErrorType.Validation);
        }

        var userResult = User.Create(
            request.Name,
            hashResult.Value!,
            request.Role);

        if (!userResult.IsSuccess)
        {
            return Result<AuthDto>.Failure(
                userResult.Message,
                ErrorType.Validation);
        }

        await _commandRepository.AddAsync(userResult.Value!, cancellationToken);

        var authDto = _jwtTokenGenerator.GenerateToken(userResult.Value!);

        return Result<AuthDto>.Success(authDto);
    }
}
