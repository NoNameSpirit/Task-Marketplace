using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.Users;
using FluentAssertions;
using NSubstitute;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using Shared.Enums;
using Task_Marketplace.Application.Handlers.Users.Queries.SearchByName;
using Xunit;

namespace Task_Marketplace.Tests.Application.Users.Queries.SearchByName;

public class SearchUsersHandlerTests
{
    private readonly IUserQueryRepository _queryRepository = Substitute.For<IUserQueryRepository>();
    private readonly SearchUsersHandler _handler;

    private const string _searchQuery = "Ivan";

    public SearchUsersHandlerTests()
    {
        _handler = new SearchUsersHandler(_queryRepository);
    }

    [Fact]
    public async Task Handle_PagedResultIsNull_ReturnFailure()
    {
        var query = new SearchUsersQuery(_searchQuery, 1, 10);
        var expectedResult = Result<PagedResult<UserDto>>.Failure(ErrorMessages.UserNotFound, ErrorType.NotFound);

        _queryRepository
             .SearchByNameAsync(Arg.Any<string>(), Arg.Any<int>(), Arg.Any<int>(), Arg.Any<CancellationToken>())
             .Returns(Task.FromResult<PagedResult<User>>(null!));

        var result = await _handler.Handle(query, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var query = new SearchUsersQuery(_searchQuery, 1, 10);
        var pagedResult = PagedResult<User>.Empty(1, 10);

        _queryRepository
             .SearchByNameAsync(Arg.Any<string>(), Arg.Any<int>(), Arg.Any<int>(), Arg.Any<CancellationToken>())
             .Returns(pagedResult);

        var result = await _handler.Handle(query, CancellationToken.None);

        result.IsSuccess.Should().BeTrue();
    }
}