using Domain.Constants;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using Shared.Enums;
using Task_Marketplace.Application.Interfaces;
using Task_Marketplace.Application.Interfaces.Repositories.Users;

namespace Task_Marketplace.Application.Handlers.Auth.Commands.Login;

public class LoginUserHandler : IRequestHandler<LoginUserCommand, Result<AuthDto>>
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

    public async Task<Result<AuthDto>> Handle(
        LoginUserCommand request,
        CancellationToken cancellationToken = default)
    {
        var user = await _queryRepository.GetByNameAsync(
            request.Name,
            cancellationToken);

        if (user is null)
        {
            return Result<AuthDto>.Failure(
                ErrorMessages.UsersNotFound,
                ErrorType.NotFound);
        }

        if (user.IsBlocked)
        {
            return Result<AuthDto>.Failure(
                ErrorMessages.UserIsBlocked,
                ErrorType.Validation);
        }

        var result = _passwordHasher.Verify(
            request.Password,
            user.PasswordHash);

        if (!result.IsSuccess)
        {
            return Result<AuthDto>.Failure(
                result.Message,
                ErrorType.Validation);
        }

        var authDto = _jwtTokenGenerator.GenerateToken(user);

        return Result<AuthDto>.Success(authDto);
    }
}
