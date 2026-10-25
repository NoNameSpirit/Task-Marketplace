using Application.Interfaces;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.ProjectTasks;
using Domain.Interfaces.Users;
using FluentAssertions;
using NSubstitute;
using Shared.Dtos.Responses;
using Shared.Enums;
using Task_Marketplace.Application.Handlers.ProjectTasks.Commands.MarkAsDone;
using Xunit;

namespace Task_Marketplace.Tests.Application.ProjectTasks.Commands.MarkAsDone;

public class MarkAsDoneHandlerTests
{
    private readonly IProjectTaskQueryRepository _taskQueryRepository = Substitute.For<IProjectTaskQueryRepository>();
    private readonly IUserQueryRepository _userQueryRepository = Substitute.For<IUserQueryRepository>();
    private readonly ICurrentUser _currentUser = Substitute.For<ICurrentUser>();
    private readonly MarkAsDoneHandler _handler;

    private const string _title = "title";
    private const string _description = "description";
    private const decimal _price = 10.0m;
    private readonly DateTimeOffset _startsAt = DateTimeOffset.UtcNow.AddDays(2);
    private readonly DateTimeOffset _endsAt = DateTimeOffset.UtcNow.AddDays(10);
    private readonly Guid _taskId = Guid.NewGuid();
    private readonly Guid _customerId = Guid.NewGuid();
    private readonly Guid _executorId = Guid.NewGuid();

    public MarkAsDoneHandlerTests()
    {
        _handler = new MarkAsDoneHandler(_taskQueryRepository, _userQueryRepository, _currentUser);
    }

    [Fact]
    public async Task Handle_TaskIsNull_ReturnFailure()
    {
        var command = new MarkAsDoneCommand(_taskId, 5m);
        var expectedResult = Result.Failure(ErrorMessages.ProjectTaskNotFound, ErrorType.NotFound);

        _taskQueryRepository
             .GetTrackedByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns((ProjectTask?)null);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_TaskMarkAsDoneFails_ReturnFailure()
    {
        var command = new MarkAsDoneCommand(_taskId, 5m);
        var expectedResult = Result.Failure(ErrorMessages.ProjectMustBeInProgress, ErrorType.Validation);
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        _taskQueryRepository
             .GetTrackedByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(task);

        _currentUser.Id.Returns(_customerId);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var command = new MarkAsDoneCommand(_taskId, 5m);
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;
        task.RespondToTask(_executorId);
        task.AssignExecutor(_executorId, _customerId);
        var executor = User.Create("executor", "hash", UserRole.Executor).Value!;

        _taskQueryRepository
             .GetTrackedByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(task);

        _currentUser.Id.Returns(_customerId);

        _userQueryRepository
             .GetTrackedByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(executor);

        _taskQueryRepository
             .GetRatingsByExecutorAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(new List<decimal> { 4m });

        var result = await _handler.Handle(command, CancellationToken.None);

        result.IsSuccess.Should().BeTrue();
    }
}