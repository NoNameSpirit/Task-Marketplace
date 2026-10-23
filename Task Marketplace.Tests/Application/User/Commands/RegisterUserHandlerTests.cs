using Application.Services.Hasher;
using Application.Services.JwtGenerator;
using Application.Users.Commands.Register;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Users;
using FluentAssertions;
using NSubstitute;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using Shared.Enums;
using Xunit;

namespace Task_Marketplace.Tests.Application.Users.Commands.Register;

public class RegisterUserHandlerTests
{
    private readonly IUserCommandRepository _commandRepository = Substitute.For<IUserCommandRepository>();
    private readonly IJwtTokenGenerator _jwtTokenGenerator = Substitute.For<IJwtTokenGenerator>();
    private readonly IPasswordHasher _passwordHasher = Substitute.For<IPasswordHasher>();
    private readonly IUserQueryRepository _queryRepository = Substitute.For<IUserQueryRepository>();
    private readonly IUnitOfWork _unitOfWork = Substitute.For<IUnitOfWork>();
    private readonly RegisterUserHandler _handler;

    private const string _name = "Ivan";
    private const string _password = "123321";
    private const string _hash = "hash";
    private const string _token = "token";

    public RegisterUserHandlerTests()
    {
        _handler = new RegisterUserHandler(_commandRepository, _jwtTokenGenerator, _passwordHasher, _queryRepository, _unitOfWork);
    }

    [Fact]
    public async Task Handle_UserAlreadyExists_ReturnFailure()
    {
        var command = new RegisterUserCommand(_name, _password, UserRole.Customer);
        var expectedResult = Result<AuthDto>.Failure(ErrorMessages.UserAlreadyExists, ErrorType.Conflict);
        var user = User.Create(_name, _hash, UserRole.Customer).Value!;

        _queryRepository
             .GetByNameAsync(Arg.Any<string>(), Arg.Any<CancellationToken>())
             .Returns(user);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_HashFails_ReturnFailure()
    {
        var command = new RegisterUserCommand(_name, _password, UserRole.Customer);
        var expectedResult = Result<AuthDto>.Failure(ErrorMessages.PasswordCannotBeEmpty, ErrorType.Validation);

        _queryRepository
             .GetByNameAsync(Arg.Any<string>(), Arg.Any<CancellationToken>())
             .Returns((User?)null);

        _passwordHasher
             .Hash(Arg.Any<string>())
             .Returns(Result<string>.Failure(ErrorMessages.PasswordCannotBeEmpty, ErrorType.Validation));

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var command = new RegisterUserCommand(_name, _password, UserRole.Customer);
        var authDto = new AuthDto(_token, _name, UserRole.Customer.ToString(), Guid.NewGuid().ToString());

        _queryRepository
             .GetByNameAsync(Arg.Any<string>(), Arg.Any<CancellationToken>())
             .Returns((User?)null);

        _passwordHasher
             .Hash(Arg.Any<string>())
             .Returns(Result<string>.Success(_hash));

        _jwtTokenGenerator
             .GenerateToken(Arg.Any<User>())
             .Returns(authDto);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.IsSuccess.Should().BeTrue();
        await _commandRepository.Received(1).AddAsync(Arg.Any<User>(), Arg.Any<CancellationToken>());
    }
}