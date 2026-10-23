using Application.Interfaces;
using Application.ProjectTasks.Commands.Create;
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

namespace Task_Marketplace.Tests.Application.ProjectTasks.Commands.Create;

public class CreateProjectTaskHandlerTests
{
    private readonly IProjectTaskCommandRepository _commandRepository = Substitute.For<IProjectTaskCommandRepository>();
    private readonly ICurrentUser _currentUser = Substitute.For<ICurrentUser>();
    private readonly CreateProjectTaskHandler _handler;

    private const string _title = "title";
    private const string _description = "description";
    private const decimal _price = 10.0m;
    private readonly DateTimeOffset _startsAt = DateTimeOffset.UtcNow.AddDays(2);
    private readonly DateTimeOffset _endsAt = DateTimeOffset.UtcNow.AddDays(10);
    private readonly Guid _customerId = Guid.NewGuid();
    private const string _currency = "$";

    public CreateProjectTaskHandlerTests()
    {
        var appConfig = Options.Create(new AppConfig { Currency = _currency });
        _handler = new CreateProjectTaskHandler(_commandRepository, appConfig, _currentUser);
    }

    [Fact]
    public async Task Handle_CreateFails_ReturnFailure()
    {
        var command = new CreateProjectTaskCommand(string.Empty, _description, _price, _startsAt, _endsAt);
        var expectedResult = Result<ProjectTaskDto>.Failure(ErrorMessages.TitleCannotBeEmpty, ErrorType.Validation);

        _currentUser.Id.Returns(_customerId);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var command = new CreateProjectTaskCommand(_title, _description, _price, _startsAt, _endsAt);

        _currentUser.Id.Returns(_customerId);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.IsSuccess.Should().BeTrue();
        await _commandRepository.Received(1).AddAsync(Arg.Any<ProjectTask>(), Arg.Any<CancellationToken>());
    }
}