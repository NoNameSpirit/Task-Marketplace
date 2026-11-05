using Domain.Entities;
using Domain.Interfaces.Users;
using FluentAssertions;
using NSubstitute;
using Shared.Dtos.Responses;
using Task_Marketplace.Application.Handlers.Users.Queries.GetAll;
using Xunit;

namespace Task_Marketplace.Tests.Application.Users.Queries.GetAll;

public class GetAllUsersHandlerTests
{
    private readonly IUserQueryRepository _queryRepository = Substitute.For<IUserQueryRepository>();
    private readonly GetAllUsersHandler _handler;

    public GetAllUsersHandlerTests()
    {
        _handler = new GetAllUsersHandler(_queryRepository);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var query = new GetAllUsersQuery(1, 10);
        var pagedResult = PagedResult<User>.Empty(1, 10);

        _queryRepository
             .GetAllAsync(Arg.Any<int>(), Arg.Any<int>(), Arg.Any<CancellationToken>())
             .Returns(pagedResult);

        var result = await _handler.Handle(query, CancellationToken.None);

        result.IsSuccess.Should().BeTrue();
    }
}