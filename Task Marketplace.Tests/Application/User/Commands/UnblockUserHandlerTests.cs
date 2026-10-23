using Application.Users.Commands.UnblockUser;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.Users;
using FluentAssertions;
using NSubstitute;
using Shared.Dtos.Responses;
using Shared.Enums;
using Xunit;

namespace Task_Marketplace.Tests.Application.Users.Commands.UnblockUser;

public class UnblockUserHandlerTests
{
    private readonly IUserQueryRepository _queryRepository = Substitute.For<IUserQueryRepository>();
    private readonly UnblockUserHandler _handler;
    private readonly Guid _userId = Guid.NewGuid();

    public UnblockUserHandlerTests()
    {
        _handler = new UnblockUserHandler(_queryRepository);
    }

    [Fact]
    public async Task Handle_UserIsNull_ReturnFailure()
    {
        var command = new UnblockUserCommand(_userId);
        var expectedResult = Result.Failure(ErrorMessages.UserNotFound, ErrorType.NotFound);

        _queryRepository
             .GetTrackedByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns((User?)null);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var command = new UnblockUserCommand(_userId);
        var user = User.Create("name", "hash", UserRole.Customer).Value!;
        user.Block();

        _queryRepository
             .GetTrackedByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(user);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.IsSuccess.Should().BeTrue();
        user.IsBlocked.Should().BeFalse();
    }
}