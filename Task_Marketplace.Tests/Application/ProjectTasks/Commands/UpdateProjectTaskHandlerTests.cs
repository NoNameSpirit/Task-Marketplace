using Application.Interfaces;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.ProjectTasks;
using FluentAssertions;
using NSubstitute;
using Shared.Dtos.Responses;
using Shared.Enums;
using Task_Marketplace.Application.Handlers.ProjectTasks.Commands.Update;
using Xunit;

namespace Task_Marketplace.Tests.Application.ProjectTasks.Commands.Update;

public class UpdateProjectTaskHandlerTests
{
    private readonly IProjectTaskQueryRepository _queryRepository = Substitute.For<IProjectTaskQueryRepository>();
    private readonly ICurrentUser _currentUser = Substitute.For<ICurrentUser>();
    private readonly UpdateProjectTaskHandler _handler;

    private const string _title = "title";
    private const string _description = "description";
    private const decimal _price = 10.0m;
    private readonly DateTimeOffset _startsAt = DateTimeOffset.UtcNow.AddDays(2);
    private readonly DateTimeOffset _endsAt = DateTimeOffset.UtcNow.AddDays(10);
    private readonly Guid _taskId = Guid.NewGuid();
    private readonly Guid _customerId = Guid.NewGuid();

    public UpdateProjectTaskHandlerTests()
    {
        _handler = new UpdateProjectTaskHandler(_queryRepository, _currentUser);
    }

    [Fact]
    public async Task Handle_TaskIsNull_ReturnFailure()
    {
        var command = new UpdateProjectTaskCommand(_taskId, _title, _description, _price, _startsAt, _endsAt);
        var expectedResult = Result.Failure(ErrorMessages.ProjectTaskNotFound, ErrorType.NotFound);

        _queryRepository
             .GetTrackedByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns((ProjectTask?)null);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_UpdateFails_ReturnFailure()
    {
        var command = new UpdateProjectTaskCommand(_taskId, _title, _description, _price, _startsAt, _endsAt);
        var expectedResult = Result.Failure(ErrorMessages.CustomerMustBeSame, ErrorType.Validation);
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        _queryRepository
             .GetTrackedByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(task);

        _currentUser.Id.Returns(Guid.NewGuid());

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var command = new UpdateProjectTaskCommand(_taskId, _title, _description, _price, _startsAt, _endsAt);
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        _queryRepository
             .GetTrackedByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(task);

        _currentUser.Id.Returns(_customerId);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.IsSuccess.Should().BeTrue();
    }
}