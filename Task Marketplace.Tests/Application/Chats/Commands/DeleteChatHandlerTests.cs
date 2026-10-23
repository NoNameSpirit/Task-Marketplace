using Application.Chats.Commands.Delete;
using Application.Interfaces;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.Chats;
using Domain.Interfaces.ProjectTasks;
using FluentAssertions;
using NSubstitute;
using Shared.Dtos.Responses;
using Shared.Enums;
using Xunit;

namespace Task_Marketplace.Tests.Application.Chats.Commands.Delete;

public class DeleteChatHandlerTests
{
    private readonly IChatCommandRepository _commandRepository = Substitute.For<IChatCommandRepository>();
    private readonly IChatQueryRepository _queryRepository = Substitute.For<IChatQueryRepository>();
    private readonly IProjectTaskQueryRepository _taskQueryRepository = Substitute.For<IProjectTaskQueryRepository>();
    private readonly ICurrentUser _currentUser = Substitute.For<ICurrentUser>();
    private readonly DeleteChatHandler _handler;

    private const string _title = "title";
    private const string _description = "description";
    private const decimal _price = 10.0m;
    private readonly DateTimeOffset _startsAt = DateTimeOffset.UtcNow.AddDays(2);
    private readonly DateTimeOffset _endsAt = DateTimeOffset.UtcNow.AddDays(10);
    private readonly Guid _customerId = Guid.NewGuid();
    private readonly Guid _chatId = Guid.NewGuid();

    public DeleteChatHandlerTests()
    {
        _handler = new DeleteChatHandler(_commandRepository, _queryRepository, _taskQueryRepository, _currentUser);
    }

    [Fact]
    public async Task Handle_ChatIsNull_ReturnFailure()
    {
        var command = new DeleteChatCommand(_chatId);
        var expectedResult = Result.Failure(ErrorMessages.ChatNotFound, ErrorType.NotFound);

        _queryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns((Chat?)null);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_TaskIsNull_ReturnFailure()
    {
        var command = new DeleteChatCommand(_chatId);
        var expectedResult = Result.Failure(ErrorMessages.Forbidden, ErrorType.Forbidden);
        var chat = Chat.Create(Guid.NewGuid()).Value!;

        _queryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(chat);

        _taskQueryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns((ProjectTask?)null);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_UserIsNotCustomer_ReturnFailure()
    {
        var command = new DeleteChatCommand(_chatId);
        var expectedResult = Result.Failure(ErrorMessages.Forbidden, ErrorType.Forbidden);
        var chat = Chat.Create(Guid.NewGuid()).Value!;
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        _queryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(chat);

        _taskQueryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(task);

        _currentUser.Id.Returns(Guid.NewGuid());

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var command = new DeleteChatCommand(_chatId);
        var expectedResult = Result.Success();
        var chat = Chat.Create(Guid.NewGuid()).Value!;
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        _queryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(chat);

        _taskQueryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(task);

        _currentUser.Id.Returns(_customerId);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
        await _commandRepository.Received(1).DeleteAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>());
    }
}