using Application.ProjectTasks.Queries.GetProjectTaskById;
using Domain.Config;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.ProjectTasks;
using FluentAssertions;
using Microsoft.Extensions.Options;
using NSubstitute;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;
using Xunit;

namespace Task_Marketplace.Tests.Application.ProjectTasks.Queries.GetProjectTaskById;

public class GetProjectTaskByIdHandlerTests
{
    private readonly IProjectTaskQueryRepository _queryRepository = Substitute.For<IProjectTaskQueryRepository>();
    private readonly GetProjectTaskByIdHandler _handler;

    private const string _currency = "$";
    private readonly Guid _taskId = Guid.NewGuid();

    public GetProjectTaskByIdHandlerTests()
    {
        var appConfig = Options.Create(new AppConfig { Currency = _currency });
        _handler = new GetProjectTaskByIdHandler(_queryRepository, appConfig);
    }

    [Fact]
    public async Task Handle_TaskIsNull_ReturnFailure()
    {
        var query = new GetProjectTaskByIdQuery(_taskId);
        var expectedResult = Result<ProjectTaskDto>.Failure(ErrorMessages.ProjectTaskNotFound, ErrorType.NotFound);

        _queryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns((ProjectTask?)null);

        var result = await _handler.Handle(query, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var query = new GetProjectTaskByIdQuery(_taskId);
        var task = ProjectTask.Create("title", "desc", 10m, DateTimeOffset.UtcNow.AddDays(2), DateTimeOffset.UtcNow.AddDays(10), Guid.NewGuid()).Value!;

        _queryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(task);

        var result = await _handler.Handle(query, CancellationToken.None);

        result.IsSuccess.Should().BeTrue();
    }
}