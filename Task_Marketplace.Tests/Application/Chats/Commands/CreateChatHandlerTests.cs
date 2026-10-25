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
using Task_Marketplace.Application.Handlers.Chats.Commands.Create;
using Xunit;

namespace Task_Marketplace.Tests.Application.Chats.Commands.Create;

public class CreateChatHandlerTests
{
    private readonly IChatCommandRepository _commandRepository = Substitute.For<IChatCommandRepository>();
    private readonly IChatQueryRepository _queryRepository = Substitute.For<IChatQueryRepository>();
    private readonly IProjectTaskQueryRepository _taskQueryRepository = Substitute.For<IProjectTaskQueryRepository>();
    private readonly ICurrentUser _currentUser = Substitute.For<ICurrentUser>();
    private readonly CreateChatHandler _handler;

    private const string _title = "title";
    private const string _description = "description";
    private const decimal _price = 10.0m;
    private readonly DateTimeOffset _startsAt = DateTimeOffset.UtcNow.AddDays(2);
    private readonly DateTimeOffset _endsAt = DateTimeOffset.UtcNow.AddDays(10);
    private readonly Guid _customerId = Guid.NewGuid();
    private readonly Guid _taskId = Guid.NewGuid();

    public CreateChatHandlerTests()
    {
        _handler = new CreateChatHandler(_commandRepository, _queryRepository, _taskQueryRepository, _currentUser);
    }

    [Fact]
    public async Task Handle_TaskIsNull_ReturnFailure()
    {
        var command = new CreateChatCommand(_taskId);
        var expectedResult = Result<ChatDto>.Failure(ErrorMessages.Forbidden, ErrorType.Forbidden);

        _taskQueryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns((ProjectTask?)null);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_UserIsNotParticipant_ReturnFailure()
    {
        var command = new CreateChatCommand(_taskId);
        var expectedResult = Result<ChatDto>.Failure(ErrorMessages.Forbidden, ErrorType.Forbidden);
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        _taskQueryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(task);

        _currentUser.Id.Returns(Guid.NewGuid());

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_ChatAlreadyExists_ReturnFailure()
    {
        var command = new CreateChatCommand(_taskId);
        var expectedResult = Result<ChatDto>.Failure(ErrorMessages.ChatAlreadyExists, ErrorType.Conflict);
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;
        var existingChat = Chat.Create(_taskId).Value!;

        _taskQueryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(task);

        _currentUser.Id.Returns(_customerId);

        _queryRepository
             .GetByTaskIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(existingChat);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var command = new CreateChatCommand(_taskId);
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        _taskQueryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(task);

        _currentUser.Id.Returns(_customerId);

        _queryRepository
             .GetByTaskIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns((Chat?)null);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.IsSuccess.Should().BeTrue();
        await _commandRepository.Received(1).AddAsync(Arg.Any<Chat>(), Arg.Any<CancellationToken>());
    }
}