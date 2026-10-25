using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.Users;
using FluentAssertions;
using NSubstitute;
using Shared.Dtos.Responses;
using Shared.Enums;
using Task_Marketplace.Application.Handlers.Users.Commands.Update;
using Xunit;

namespace Task_Marketplace.Tests.Application.Users.Commands.Update;

public class UpdateUserHandlerTests
{
    private readonly IUserQueryRepository _queryRepository = Substitute.For<IUserQueryRepository>();
    private readonly IUserCommandRepository _commandRepository = Substitute.For<IUserCommandRepository>();
    private readonly UpdateUserHandler _handler;
    private readonly Guid _userId = Guid.NewGuid();

    private const string _name = "name";
    private const string _hash = "hash";

    public UpdateUserHandlerTests()
    {
        _handler = new UpdateUserHandler(_queryRepository, _commandRepository);
    }

    [Fact]
    public async Task Handle_UserIsNull_ReturnFailure()
    {
        var command = new UpdateUserCommand(_userId, _name);
        var expectedResult = Result.Failure(ErrorMessages.UserNotFound, ErrorType.NotFound);

        _queryRepository
             .GetTrackedByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns((User?)null);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_UpdateFails_ReturnFailure()
    {
        var command = new UpdateUserCommand(_userId, string.Empty);
        var expectedResult = Result.Failure(ErrorMessages.UserNameCannotBeEmpty, ErrorType.Validation);
        var user = User.Create(_name, _hash, UserRole.Customer).Value!;

        _queryRepository
             .GetTrackedByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(user);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var command = new UpdateUserCommand(_userId, "newName");
        var user = User.Create(_name, _hash, UserRole.Customer).Value!;

        _queryRepository
             .GetTrackedByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(user);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.IsSuccess.Should().BeTrue();
        await _commandRepository.Received(1).UpdateAsync(Arg.Any<User>(), Arg.Any<CancellationToken>());
    }
}