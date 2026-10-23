using Application.Interfaces;
using Application.ProjectTasks.Queries.GetPublishedTasks;
using Domain.Config;
using Domain.Entities;
using Domain.Interfaces.ProjectTasks;
using FluentAssertions;
using Microsoft.Extensions.Options;
using NSubstitute;
using Shared.Dtos.Responses;
using Xunit;

namespace Task_Marketplace.Tests.Application.ProjectTasks.Queries.GetPublishedTasks;

public class GetPublishedTasksHandlerTests
{
    private readonly IProjectTaskQueryRepository _queryRepository = Substitute.For<IProjectTaskQueryRepository>();
    private readonly ICurrentUser _currentUser = Substitute.For<ICurrentUser>();
    private readonly GetPublishedTasksHandler _handler;

    private const string _currency = "$";
    private readonly Guid _executorId = Guid.NewGuid();

    public GetPublishedTasksHandlerTests()
    {
        var appConfig = Options.Create(new AppConfig { Currency = _currency });
        _handler = new GetPublishedTasksHandler(_queryRepository, appConfig, _currentUser);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var query = new GetPublishedTasksQuery(1, 10);
        var pagedResult = PagedResult<ProjectTask>.Empty(1, 10);

        _currentUser.Id.Returns(_executorId);

        _queryRepository
             .GetPublishedAsync(Arg.Any<int>(), Arg.Any<int>(), Arg.Any<CancellationToken>())
             .Returns(pagedResult);

        var result = await _handler.Handle(query, CancellationToken.None);

        result.IsSuccess.Should().BeTrue();
    }
}