using Application.Chats.Queries.GetByTaskId;
using Application.Interfaces;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.Chats;
using Domain.Interfaces.ProjectTasks;
using FluentAssertions;
using NSubstitute;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;
using Shared.Enums;
using Xunit;

namespace Task_Marketplace.Tests.Application.Chats.Queries.GetByTaskId;

public class GetChatByTaskIdHandlerTests
{
    private readonly IChatQueryRepository _queryRepository = Substitute.For<IChatQueryRepository>();
    private readonly IProjectTaskQueryRepository _taskQueryRepository = Substitute.For<IProjectTaskQueryRepository>();
    private readonly ICurrentUser _currentUser = Substitute.For<ICurrentUser>();
    private readonly GetChatByTaskIdHandler _handler;

    private const string _title = "title";
    private const string _description = "description";
    private const decimal _price = 10.0m;
    private readonly DateTimeOffset _startsAt = DateTimeOffset.UtcNow.AddDays(2);
    private readonly DateTimeOffset _endsAt = DateTimeOffset.UtcNow.AddDays(10);
    private readonly Guid _customerId = Guid.NewGuid();
    private readonly Guid _taskId = Guid.NewGuid();

    public GetChatByTaskIdHandlerTests()
    {
        _handler = new GetChatByTaskIdHandler(_queryRepository, _taskQueryRepository, _currentUser);
    }

    [Fact]
    public async Task Handle_TaskIsNull_ReturnFailure()
    {
        var query = new GetChatByTaskIdQuery(_taskId);
        var expectedResult = Result<ChatDto>.Failure(ErrorMessages.ProjectTaskNotFound, ErrorType.NotFound);

        _taskQueryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns((ProjectTask?)null);

        var result = await _handler.Handle(query, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_UserIsNotParticipant_ReturnFailure()
    {
        var query = new GetChatByTaskIdQuery(_taskId);
        var expectedResult = Result<ChatDto>.Failure(ErrorMessages.Forbidden, ErrorType.Forbidden);
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        _taskQueryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(task);

        _currentUser.Id.Returns(Guid.NewGuid());

        var result = await _handler.Handle(query, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_ChatIsNull_ReturnFailure()
    {
        var query = new GetChatByTaskIdQuery(_taskId);
        var expectedResult = Result<ChatDto>.Failure(ErrorMessages.ChatNotFound, ErrorType.NotFound);
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        _taskQueryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(task);

        _currentUser.Id.Returns(_customerId);

        _queryRepository
             .GetByTaskIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns((Chat?)null);

        var result = await _handler.Handle(query, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var query = new GetChatByTaskIdQuery(_taskId);
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;
        var chat = Chat.Create(_taskId).Value!;

        _taskQueryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(task);

        _currentUser.Id.Returns(_customerId);

        _queryRepository
             .GetByTaskIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(chat);

        _queryRepository
             .GetUserNamesAsync(Arg.Any<IEnumerable<Guid>>(), Arg.Any<CancellationToken>())
             .Returns(new Dictionary<Guid, string>());

        var result = await _handler.Handle(query, CancellationToken.None);

        result.IsSuccess.Should().BeTrue();
    }
}