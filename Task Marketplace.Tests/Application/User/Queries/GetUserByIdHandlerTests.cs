using Application.Users.Queries.GetById;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.Users;
using FluentAssertions;
using NSubstitute;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using Shared.Enums;
using Xunit;

namespace Task_Marketplace.Tests.Application.Users.Queries.GetById;

public class GetUserByIdHandlerTests
{
    private readonly IUserQueryRepository _queryRepository = Substitute.For<IUserQueryRepository>();
    private readonly GetUserByIdHandler _handler;
    private readonly Guid _userId = Guid.NewGuid();

    public GetUserByIdHandlerTests()
    {
        _handler = new GetUserByIdHandler(_queryRepository);
    }

    [Fact]
    public async Task Handle_UserIsNull_ReturnFailure()
    {
        var query = new GetUserByIdQuery(_userId);
        var expectedResult = Result<UserDto>.Failure(ErrorMessages.UserNotFound, ErrorType.NotFound);

        _queryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns((User?)null);

        var result = await _handler.Handle(query, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var query = new GetUserByIdQuery(_userId);
        var user = User.Create("name", "hash", UserRole.Customer).Value!;

        _queryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(user);

        var result = await _handler.Handle(query, CancellationToken.None);

        result.IsSuccess.Should().BeTrue();
    }
}