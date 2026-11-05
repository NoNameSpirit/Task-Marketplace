using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.Users;
using FluentAssertions;
using NSubstitute;
using Shared.Dtos.Responses;
using Shared.Enums;
using Task_Marketplace.Application.Handlers.Users.Commands.ChangeRole;
using Xunit;

namespace Task_Marketplace.Tests.Application.Users.Commands.ChangeRole;

public class ChangeRoleHandlerTests
{
    private readonly IUserQueryRepository _queryRepository = Substitute.For<IUserQueryRepository>();
    private readonly ChangeRoleHandler _handler;
    private readonly Guid _userId = Guid.NewGuid();

    public ChangeRoleHandlerTests()
    {
        _handler = new ChangeRoleHandler(_queryRepository);
    }

    [Fact]
    public async Task Handle_UserIsNull_ReturnFailure()
    {
        var command = new ChangeRoleCommand(_userId, UserRole.Admin);
        var expectedResult = Result.Failure(ErrorMessages.UserNotFound, ErrorType.NotFound);

        _queryRepository
             .GetTrackedByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns((User?)null);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_ChangeRoleFails_ReturnFailure()
    {
        var command = new ChangeRoleCommand(_userId, UserRole.Admin);
        var expectedResult = Result.Failure(ErrorMessages.AdminRoleCannotSetup, ErrorType.Validation);
        var user = User.Create("name", "hash", UserRole.Customer).Value!;

        _queryRepository
             .GetTrackedByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(user);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var command = new ChangeRoleCommand(_userId, UserRole.Executor);
        var user = User.Create("name", "hash", UserRole.Customer).Value!;

        _queryRepository
             .GetTrackedByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(user);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.IsSuccess.Should().BeTrue();
    }
}