using Application.Interfaces;
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
using Task_Marketplace.Application.Handlers.ProjectTasks.Queries.GetByCustomer;
using Xunit;

namespace Task_Marketplace.Tests.Application.ProjectTasks.Queries.GetTasksByCustomer;

public class GetTasksByCustomerHandlerTests
{
    private readonly IProjectTaskQueryRepository _queryRepository = Substitute.For<IProjectTaskQueryRepository>();
    private readonly ICurrentUser _currentUser = Substitute.For<ICurrentUser>();
    private readonly GetTasksByCustomerHandler _handler;

    private const string _currency = "$";
    private readonly Guid _customerId = Guid.NewGuid();

    public GetTasksByCustomerHandlerTests()
    {
        var appConfig = Options.Create(new AppConfig { Currency = _currency });
        _handler = new GetTasksByCustomerHandler(_queryRepository, appConfig, _currentUser);
    }

    [Fact]
    public async Task Handle_UserIsNotCustomer_ReturnFailure()
    {
        var query = new GetTasksByCustomerQuery(_customerId, 1, 10);
        var expectedResult = Result<PagedResult<ProjectTaskDto>>.Failure(ErrorMessages.CustomerWithSameId, ErrorType.Forbidden);

        _currentUser.Id.Returns(Guid.NewGuid());

        var result = await _handler.Handle(query, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var query = new GetTasksByCustomerQuery(_customerId, 1, 10);
        var pagedResult = PagedResult<ProjectTask>.Empty(1, 10);

        _currentUser.Id.Returns(_customerId);

        _queryRepository
             .GetByCustomerIdAsync(Arg.Any<Guid>(), Arg.Any<int>(), Arg.Any<int>(), Arg.Any<CancellationToken>())
             .Returns(pagedResult);

        var result = await _handler.Handle(query, CancellationToken.None);

        result.IsSuccess.Should().BeTrue();
    }
}