using Application.Services.Hasher;
using Application.Services.JwtGenerator;
using Application.Users.Commands.Login;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.Users;
using FluentAssertions;
using NSubstitute;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using Shared.Enums;
using Xunit;

namespace Task_Marketplace.Tests.Application.Users.Commands.Login;

public class LoginUserHandlerTests
{
    private readonly IUserQueryRepository _queryRepository = Substitute.For<IUserQueryRepository>();
    private readonly IJwtTokenGenerator _jwtTokenGenerator = Substitute.For<IJwtTokenGenerator>();
    private readonly IPasswordHasher _passwordHasher = Substitute.For<IPasswordHasher>();
    private readonly LoginUserHandler _handler;

    private const string _name = "Ivan";
    private const string _password = "123321";
    private const string _hash = "hash";
    private const string _token = "token";

    public LoginUserHandlerTests()
    {
        _handler = new LoginUserHandler(_queryRepository, _jwtTokenGenerator, _passwordHasher);
    }

    [Fact]
    public async Task Handle_UserIsNull_ReturnFailure()
    {
        var command = new LoginUserCommand(_name, _password);
        var expectedResult = Result<AuthDto>.Failure(ErrorMessages.UsersNotFound, ErrorType.NotFound);

        _queryRepository
             .GetByNameAsync(Arg.Any<string>(), Arg.Any<CancellationToken>())
             .Returns((User?)null);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_UserIsBlocked_ReturnFailure()
    {
        var command = new LoginUserCommand(_name, _password);
        var expectedResult = Result<AuthDto>.Failure(ErrorMessages.UserIsBlocked, ErrorType.Validation);
        var user = User.Create(_name, _hash, UserRole.Customer).Value!;
        user.Block();

        _queryRepository
             .GetByNameAsync(Arg.Any<string>(), Arg.Any<CancellationToken>())
             .Returns(user);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_IncorrectPassword_ReturnFailure()
    {
        var command = new LoginUserCommand(_name, _password);
        var expectedResult = Result<AuthDto>.Failure(ErrorMessages.IncorrectLoginOrPassword, ErrorType.Validation);
        var user = User.Create(_name, _hash, UserRole.Customer).Value!;

        _queryRepository
             .GetByNameAsync(Arg.Any<string>(), Arg.Any<CancellationToken>())
             .Returns(user);

        _passwordHasher
             .Verify(Arg.Any<string>(), Arg.Any<string>())
             .Returns(Result.Failure(ErrorMessages.IncorrectLoginOrPassword));

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var command = new LoginUserCommand(_name, _password);
        var user = User.Create(_name, _hash, UserRole.Customer).Value!;
        var authDto = new AuthDto(_token, _name, UserRole.Customer.ToString(), Guid.NewGuid().ToString());

        _queryRepository
             .GetByNameAsync(Arg.Any<string>(), Arg.Any<CancellationToken>())
             .Returns(user);

        _passwordHasher
             .Verify(Arg.Any<string>(), Arg.Any<string>())
             .Returns(Result.Success());

        _jwtTokenGenerator
             .GenerateToken(Arg.Any<User>())
             .Returns(authDto);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.IsSuccess.Should().BeTrue();
    }
}