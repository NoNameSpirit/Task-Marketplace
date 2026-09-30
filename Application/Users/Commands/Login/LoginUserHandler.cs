using Application.Services.Hasher;
using Application.Services.JwtGenerator;
using Domain.Constants;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos;

namespace Application.Users.Commands.Login;

public class LoginUserHandler : IRequestHandler<LoginUserCommand, Result<string>>
{
    private readonly IUserQueryRepository _queryRepository;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IPasswordHasher _passwordHasher;

    public LoginUserHandler(
        IUserQueryRepository queryRepository,
        IJwtTokenGenerator jwtTokenGenerator,
        IPasswordHasher passwordHasher)
    {
        _queryRepository = queryRepository;
        _jwtTokenGenerator = jwtTokenGenerator;
        _passwordHasher = passwordHasher;
    }

    public async Task<Result<string>> Handle(
        LoginUserCommand request,
        CancellationToken cancellationToken = default)
    {
        var user = await _queryRepository.GetByNameAsync(
            request.Name,
            cancellationToken);

        if (user is null)
        {
            return Result<string>.Failure(ErrorMessages.UsersNotFound);
        }

        var result = _passwordHasher.Verify(
            request.Password,
            user.PasswordHash);

        if (!result.IsSuccess)
        {
            return Result<string>.Failure(result.Message);
        }

        var token = _jwtTokenGenerator.GenerateToken(user);

        return Result<string>.Success(token);
    }
}
