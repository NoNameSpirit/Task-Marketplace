/*using Application.Services.Hasher;
using Application.Services.JwtGenerator;
using Application.Users.Commands.Login;
using Application.Users.Commands.Register;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.Users;
using FluentAssertions;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using Shared.Dtos.Requests.Users;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using Shared.Enums;
using Web_Api.Controllers;
using Xunit;

namespace Task_Marketplace.Tests.Web_Api.Controllers;

public class AuthControllerTests
{
    private readonly IMediator _mediatr;
    private readonly AuthController _authControler;

    private const string correctName = "Ivan";
    private const string correctPassword = "123321";
    private const string correctHash = "hash";
    private const string correctToken = "token";
    private const UserRole correctRole = UserRole.Executor;

    public AuthControllerTests()
    {
        _mediatr = Substitute.For<IMediator>();

        _authControler = new AuthController(_mediatr);
    }

    [Fact]
    public async Task Register_DublicateUser_ReturnsFailedConflict()
    {
        var command = new RegisterUserDto(correctName, correctPassword, correctRole);

        var result = Result<AuthDto>.Failure(ErrorMessages.UserAlreadyExists, ErrorType.Conflict);

        _mediatr
            .Send(Arg.Any<RegisterUserCommand>(), Arg.Any<CancellationToken>())
            .Returns(result);

        var response = await _authControler.Register(command, CancellationToken.None);

        var objectResult = response.Should().BeOfType<ObjectResult>().Subject;
        objectResult.StatusCode.Should().Be(StatusCodes.Status409Conflict);
    }

    [Fact]
    public async Task Register_EmptyPassword_ReturnsFailedValidation()
    {
        var command = new RegisterUserDto(correctName, string.Empty, correctRole);

        var result = Result<AuthDto>.Failure(ErrorMessages.PasswordCannotBeEmpty, ErrorType.Validation);

        _mediatr
            .Send(Arg.Any<RegisterUserCommand>(), Arg.Any<CancellationToken>())
            .Returns(result);

        var response = await _authControler.Register(command, CancellationToken.None);

        var objectResult = response.Should().BeOfType<ObjectResult>().Subject;
        objectResult.StatusCode.Should().Be(StatusCodes.Status400BadRequest);
    }

    [Fact]
    public async Task Register_NotCorrectDataForUser_ReturnsFailedValidation()
    {
        var command = new RegisterUserDto(correctName, correctPassword, UserRole.Admin);

        var result = Result<AuthDto>.Failure(ErrorMessages.AdminRoleCannotSetup, ErrorType.Validation);

        _mediatr
            .Send(Arg.Any<RegisterUserCommand>(), Arg.Any<CancellationToken>())
            .Returns(result);

        var response = await _authControler.Register(command, CancellationToken.None);

        var objectResult = response.Should().BeOfType<ObjectResult>().Subject;
        objectResult.StatusCode.Should().Be(StatusCodes.Status400BadRequest);
    }

    [Fact]
    public async Task Register_CorrectData_ReturnsSuccsess()
    {
        var command = new RegisterUserDto(correctName, correctPassword, correctRole);

        var result = Result<AuthDto>.Success(new AuthDto(correctToken, correctName, correctRole.ToString(), Guid.NewGuid().ToString()));

        _mediatr
            .Send(Arg.Any<RegisterUserCommand>(), Arg.Any<CancellationToken>())
            .Returns(result);

        var response = await _authControler.Register(command, CancellationToken.None);

        var objectResult = response.Should().BeOfType<OkObjectResult>().Subject;
        var dto = objectResult.Value.Should().BeOfType<AuthDto>().Subject;
        dto.Token.Should().Be(correctToken);
    }

    [Fact]
    public async Task Login_UserNotExists_ReturnsFailedNotFound()
    {
        var command = new LoginDto(correctName, correctPassword);

        var result = Result<AuthDto>.Failure(ErrorMessages.UserAlreadyExists, ErrorType.Conflict);

        _mediatr
            .Send(Arg.Any<LoginUserCommand>(), Arg.Any<CancellationToken>())
            .Returns(result);

        var response = await _authControler.Login(command, CancellationToken.None);

        var objectResult = response.Should().BeOfType<ObjectResult>().Subject;
        objectResult.StatusCode.Should().Be(StatusCodes.Status404NotFound);
    }

    [Fact]
    public async Task Login_UserIsBlocked_ReturnsFailedValidationd()
    {
        var queryRepository = Substitute.For<IUserQueryRepository>();
        var jwtGenerator = Substitute.For<IJwtTokenGenerator>();
        var hasher = Substitute.For<IPasswordHasher>();

        var handler = new LoginUserHandler(queryRepository, jwtGenerator, hasher);
        var command = new LoginUserCommand(correctName, correctPassword);

        var user = User.Create(correctName, correctHash, correctRole).Value!;
        user.Block();

        queryRepository
            .GetByNameAsync(command.Name, CancellationToken.None)
            .Returns(user);

        var response = await handler.Handle(command, CancellationToken.None);

        response.IsSuccess.Should().BeFalse();
        response.Error.Should().Be(ErrorType.Validation);
        response.Message.Should().Be(ErrorMessages.UserIsBlocked);

        hasher.DidNotReceive().Verify(Arg.Any<string>(), Arg.Any<string>());
        jwtGenerator.DidNotReceive().GenerateToken(Arg.Any<User>());
    }

    [Fact]
    public async Task Login_UserNotExists_ReturnsFailedValidation()
    {
        var command = new LoginDto(correctName, correctPassword);

        var result = Result<AuthDto>.Failure(ErrorMessages.UserAlreadyExists, ErrorType.Conflict);

        _mediatr
            .Send(Arg.Any<LoginUserCommand>(), Arg.Any<CancellationToken>())
            .Returns(result);

        var response = await _authControler.Login(command, CancellationToken.None);

        var objectResult = response.Should().BeOfType<ObjectResult>().Subject;
        objectResult.StatusCode.Should().Be(StatusCodes.Status404NotFound);
    }

    [Fact]
    public async Task Login_IncorrectPassword_ReturnsFailedValidation()
    {
        var command = new LoginDto(correctName, string.Empty);

        var result = Result<AuthDto>.Failure(ErrorMessages.IncorrectLoginOrPassword, ErrorType.Validation);

        _mediatr
            .Send(Arg.Any<LoginUserCommand>(), Arg.Any<CancellationToken>())
            .Returns(result);

        var response = await _authControler.Login(command, CancellationToken.None);

        var objectResult = response.Should().BeOfType<ObjectResult>().Subject;
        objectResult.StatusCode.Should().Be(StatusCodes.Status400BadRequest);
    }

    [Fact]
    public async Task Login_CorrectData_ReturnsSuccess()
    {
        var command = new LoginDto(correctName, correctPassword);

        var result = Result<AuthDto>.Success(
            new AuthDto(correctToken, correctName, correctRole.ToString(), Guid.NewGuid().ToString()));

        _mediatr
            .Send(Arg.Any<LoginUserCommand>(), Arg.Any<CancellationToken>())
            .Returns(result);

        var response = await _authControler.Login(command, CancellationToken.None);

        var objectResult = response.Should().BeOfType<OkObjectResult>().Subject;
        var dto = objectResult.Value.Should().BeOfType<AuthDto>().Subject;
        dto.Token.Should().Be(correctToken);
    }
}*/