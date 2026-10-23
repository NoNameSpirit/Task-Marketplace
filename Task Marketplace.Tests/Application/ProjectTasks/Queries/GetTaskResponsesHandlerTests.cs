using Application.Interfaces;
using Application.ProjectTasks.Queries.GetResponses;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.ProjectTasks;
using FluentAssertions;
using NSubstitute;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;
using Xunit;

namespace Task_Marketplace.Tests.Application.ProjectTasks.Queries.GetResponses;

public class GetTaskResponsesHandlerTests
{
    private readonly IProjectTaskQueryRepository _queryRepository = Substitute.For<IProjectTaskQueryRepository>();
    private readonly ICurrentUser _currentUser = Substitute.For<ICurrentUser>();
    private readonly GetTaskResponsesHandler _handler;

    private readonly Guid _taskId = Guid.NewGuid();
    private readonly Guid _customerId = Guid.NewGuid();

    public GetTaskResponsesHandlerTests()
    {
        _handler = new GetTaskResponsesHandler(_queryRepository, _currentUser);
    }

    [Fact]
    public async Task Handle_TaskIsNull_ReturnFailure()
    {
        var query = new GetTaskResponsesQuery(_taskId);
        var expectedResult = Result<List<TaskResponseDto>>.Failure(ErrorMessages.ProjectTaskNotFound, ErrorType.NotFound);

        _queryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns((ProjectTask?)null);

        var result = await _handler.Handle(query, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_UserIsNotCustomer_ReturnFailure()
    {
        var query = new GetTaskResponsesQuery(_taskId);
        var expectedResult = Result<List<TaskResponseDto>>.Failure(ErrorMessages.Forbidden, ErrorType.Forbidden);
        var task = ProjectTask.Create("title", "desc", 10m, DateTimeOffset.UtcNow.AddDays(2), DateTimeOffset.UtcNow.AddDays(10), _customerId).Value!;

        _queryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(task);

        _currentUser.Id.Returns(Guid.NewGuid());

        var result = await _handler.Handle(query, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var query = new GetTaskResponsesQuery(_taskId);
        var task = ProjectTask.Create("title", "desc", 10m, DateTimeOffset.UtcNow.AddDays(2), DateTimeOffset.UtcNow.AddDays(10), _customerId).Value!;

        _queryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(task);

        _currentUser.Id.Returns(_customerId);

        _queryRepository
             .GetResponsesByTaskIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(new List<TaskResponseDto>());

        var result = await _handler.Handle(query, CancellationToken.None);

        result.IsSuccess.Should().BeTrue();
    }
}