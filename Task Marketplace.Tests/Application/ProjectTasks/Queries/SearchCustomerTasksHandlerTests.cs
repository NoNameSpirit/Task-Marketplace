using Application.ProjectTasks.Queries.SearchTasks;
using Domain.Config;
using Domain.Entities;
using Domain.Interfaces.ProjectTasks;
using FluentAssertions;
using Microsoft.Extensions.Options;
using NSubstitute;
using Shared.Dtos.Responses;
using Xunit;

namespace Task_Marketplace.Tests.Application.ProjectTasks.Queries.SearchTasks;

public class SearchCustomerTasksHandlerTests
{
    private readonly IProjectTaskQueryRepository _queryRepository = Substitute.For<IProjectTaskQueryRepository>();
    private readonly SearchCustomerTasksHandler _handler;

    private const string _currency = "$";
    private const string _searchQuery = "test";
    private readonly Guid _customerId = Guid.NewGuid();

    public SearchCustomerTasksHandlerTests()
    {
        var appConfig = Options.Create(new AppConfig { Currency = _currency });
        _handler = new SearchCustomerTasksHandler(_queryRepository, appConfig);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var query = new SearchCustomerTasksQuery(_customerId, _searchQuery, 1, 10);
        var pagedResult = PagedResult<ProjectTask>.Empty(1, 10);

        _queryRepository
             .SearchByCustomerIdAsync(Arg.Any<Guid>(), Arg.Any<string>(), Arg.Any<int>(), Arg.Any<int>(), Arg.Any<CancellationToken>())
             .Returns(pagedResult);

        var result = await _handler.Handle(query, CancellationToken.None);

        result.IsSuccess.Should().BeTrue();
    }
}