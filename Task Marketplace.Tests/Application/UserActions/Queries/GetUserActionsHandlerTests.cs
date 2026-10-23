using Application.UserActions.Queries.GetUserActions;
using Domain.Entities;
using Domain.Interfaces.UserActions;
using Domain.Interfaces.Users;
using FluentAssertions;
using NSubstitute;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.UserActions;
using Xunit;

namespace Task_Marketplace.Tests.Application.UserActions.Queries.GetUserActions;

public class GetUserActionsHandlerTests
{
    private readonly IUserActionQueryRepository _actionRepository = Substitute.For<IUserActionQueryRepository>();
    private readonly IUserQueryRepository _userRepository = Substitute.For<IUserQueryRepository>();
    private readonly GetUserActionsHandler _handler;

    public GetUserActionsHandlerTests()
    {
        _handler = new GetUserActionsHandler(_actionRepository, _userRepository);
    }

    [Fact]
    public async Task Handle_EmptyPagedResult_ReturnEmptySuccess()
    {
        var query = new GetUserActionsQuery(null, null, 1, 10);
        var expectedResult = Result<PagedResult<UserActionDto>>.Success(PagedResult<UserActionDto>.Empty(1, 10));

        _actionRepository
             .GetAsync(Arg.Any<Guid?>(), Arg.Any<int?>(), Arg.Any<int>(), Arg.Any<int>(), Arg.Any<CancellationToken>())
             .Returns(PagedResult<UserAction>.Empty(1, 10));

        var result = await _handler.Handle(query, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var query = new GetUserActionsQuery(null, null, 1, 10);
        var action = UserAction.Create(Guid.NewGuid(), Shared.Enums.UserActionType.CreatedChat, "entity").Value!;
        var pagedResult = PagedResult<UserAction>.Create(new List<UserAction> { action }, 1, 10, 1);

        _actionRepository
             .GetAsync(Arg.Any<Guid?>(), Arg.Any<int?>(), Arg.Any<int>(), Arg.Any<int>(), Arg.Any<CancellationToken>())
             .Returns(pagedResult);

        _userRepository
             .GetNamesByIdsAsync(Arg.Any<IReadOnlyCollection<Guid>>(), Arg.Any<CancellationToken>())
             .Returns(new Dictionary<Guid, string>());

        var result = await _handler.Handle(query, CancellationToken.None);

        result.IsSuccess.Should().BeTrue();
    }
}