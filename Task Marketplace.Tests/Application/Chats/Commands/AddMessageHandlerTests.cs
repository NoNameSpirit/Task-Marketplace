using Application.Chats.Commands.AddMessage;
using Application.Interfaces;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.Chats;
using Domain.Interfaces.ProjectTasks;
using Domain.Interfaces.Users;
using FluentAssertions;
using NSubstitute;
using Shared.Dtos.Responses;
using Shared.Enums;
using Xunit;

namespace Task_Marketplace.Tests.Application.Chats.Commands.AddMessage;

public class AddMessageHandlerTests
{
    private readonly IChatQueryRepository _chatQueryRepository = Substitute.For<IChatQueryRepository>();
    private readonly IUserQueryRepository _userQueryRepository = Substitute.For<IUserQueryRepository>();
    private readonly IProjectTaskQueryRepository _taskQueryRepository = Substitute.For<IProjectTaskQueryRepository>();
    private readonly ICurrentUser _currentUser = Substitute.For<ICurrentUser>();
    private readonly AddMessageHandler _handler;

    private const string _messageText = "Hello";
    private readonly Guid _chatId = Guid.NewGuid();
    private readonly Guid _customerId = Guid.NewGuid();

    public AddMessageHandlerTests()
    {
        _handler = new AddMessageHandler(_chatQueryRepository, _userQueryRepository, _taskQueryRepository, _currentUser);
    }

    [Fact]
    public async Task Handle_ChatIsNull_ReturnFailure()
    {
        var command = new AddMessageCommand(_chatId, _messageText);
        var expectedResult = Result.Failure(ErrorMessages.ChatNotFound, ErrorType.NotFound);

        _chatQueryRepository
             .GetTrackedByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns((Chat?)null);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_TaskIsNull_ReturnFailure()
    {
        var command = new AddMessageCommand(_chatId, _messageText);
        var expectedResult = Result.Failure(ErrorMessages.Forbidden, ErrorType.Forbidden);
        var chat = Chat.Create(Guid.NewGuid()).Value!;

        _chatQueryRepository
             .GetTrackedByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(chat);

        _taskQueryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns((ProjectTask?)null);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_UserIsNotParticipant_ReturnFailure()
    {
        var command = new AddMessageCommand(_chatId, _messageText);
        var expectedResult = Result.Failure(ErrorMessages.Forbidden, ErrorType.Forbidden);

        var chat = Chat.Create(Guid.NewGuid()).Value!;
        var task = ProjectTask.Create("title", "description", 10.0m, DateTimeOffset.UtcNow.AddDays(2), DateTimeOffset.UtcNow.AddDays(10), _customerId).Value!;

        _chatQueryRepository
             .GetTrackedByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(chat);

        _taskQueryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(task);

        _currentUser.Id
            .Returns(Guid.NewGuid());

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_SenderIsNull_ReturnFailure()
    {
        var command = new AddMessageCommand(_chatId, _messageText);
        var expectedResult = Result.Failure(ErrorMessages.UserNotFound, ErrorType.NotFound);

        var chat = Chat.Create(Guid.NewGuid()).Value!;
        var task = ProjectTask.Create("title", "description", 10.0m, DateTimeOffset.UtcNow.AddDays(2), DateTimeOffset.UtcNow.AddDays(10), _customerId).Value!;

        _chatQueryRepository
             .GetTrackedByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(chat);

        _taskQueryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(task);

        _currentUser.Id
            .Returns(_customerId);

        _userQueryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns((User?)null);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_MessageTextIsEmpty_ReturnFailure()
    {
        var command = new AddMessageCommand(_chatId, string.Empty);
        var expectedResult = Result.Failure(ErrorMessages.MessageTextCannotBeEmpty, ErrorType.Validation);

        var chat = Chat.Create(Guid.NewGuid()).Value!;
        var task = ProjectTask.Create("title", "description", 10.0m, DateTimeOffset.UtcNow.AddDays(2), DateTimeOffset.UtcNow.AddDays(10), _customerId).Value!;
        var sender = User.Create("Name", "Hash", UserRole.Customer).Value!;

        _chatQueryRepository
             .GetTrackedByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(chat);

        _taskQueryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(task);

        _currentUser.Id
            .Returns(_customerId);

        _userQueryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(sender);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var command = new AddMessageCommand(_chatId, _messageText);
        var expectedResult = Result.Success();

        var chat = Chat.Create(Guid.NewGuid()).Value!;
        var task = ProjectTask.Create("title", "description", 10.0m, DateTimeOffset.UtcNow.AddDays(2), DateTimeOffset.UtcNow.AddDays(10), _customerId).Value!;
        var sender = User.Create("Name", "Hash", UserRole.Customer).Value!;

        _chatQueryRepository
             .GetTrackedByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(chat);

        _taskQueryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(task);

        _currentUser.Id
            .Returns(_customerId);

        _userQueryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(sender);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }
}