using Application.Users.Queries.GetUsers;
using Domain.Entities;
using Domain.Interfaces.Users;
using FluentAssertions;
using NSubstitute;
using Shared.Dtos.Responses;
using Xunit;

namespace Task_Marketplace.Tests.Application.Users.Queries.GetUsers;

public class GetUsersHandlerTests
{
    private readonly IUserQueryRepository _userRepository = Substitute.For<IUserQueryRepository>();
    private readonly GetUsersHandler _handler;

    public GetUsersHandlerTests()
    {
        _handler = new GetUsersHandler(_userRepository);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var query = new GetUsersQuery(1, 10);
        var pagedResult = PagedResult<User>.Empty(1, 10);

        _userRepository
             .GetPagedAsync(Arg.Any<int>(), Arg.Any<int>(), Arg.Any<CancellationToken>())
             .Returns(pagedResult);

        var result = await _handler.Handle(query, CancellationToken.None);

        result.IsSuccess.Should().BeTrue();
    }
}