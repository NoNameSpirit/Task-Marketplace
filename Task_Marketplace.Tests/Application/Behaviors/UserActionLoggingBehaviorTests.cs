using Application.Behaviors;
using Application.Common;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.UserActions;
using MediatR;
using NSubstitute;
using Shared.Dtos.Responses;
using Shared.Enums;
using Xunit;

namespace Task_Marketplace.Tests.Application.Behaviors;

public class UserActionLoggingBehaviorTests
{
    private readonly IUserActionCommandRepository _repository = Substitute.For<IUserActionCommandRepository>();
    private readonly ICurrentUser _currentUser = Substitute.For<ICurrentUser>();

    public record CommandWithoutAttribute : IRequest<Result>;

    [LogAction(UserActionType.CreatedChat, nameof(Chat))]
    public record CommandWithAttribute : IRequest<Result>;

    [Fact]
    public async Task Handle_NoAttribute_ShouldNotAddAction()
    {
        var behavior = new UserActionLoggingBehavior<CommandWithoutAttribute, Result>(_repository, _currentUser);
        RequestHandlerDelegate<Result> next = (ct) => Task.FromResult(Result.Success());

        await behavior.Handle(new CommandWithoutAttribute(), next, CancellationToken.None);

        await _repository.DidNotReceive().AddAsync(Arg.Any<UserAction>(), Arg.Any<CancellationToken>());
    }

    [Fact]
    public async Task Handle_HasAttributeAndSuccess_ShouldAddAction()
    {
        var behavior = new UserActionLoggingBehavior<CommandWithAttribute, Result>(_repository, _currentUser);
        RequestHandlerDelegate<Result> next = (ct) => Task.FromResult(Result.Success());
        _currentUser.Id.Returns(Guid.NewGuid());

        await behavior.Handle(new CommandWithAttribute(), next, CancellationToken.None);

        await _repository.Received(1).AddAsync(Arg.Any<UserAction>(), Arg.Any<CancellationToken>());
    }

    [Fact]
    public async Task Handle_HasAttributeButFailure_ShouldNotAddAction()
    {
        var behavior = new UserActionLoggingBehavior<CommandWithAttribute, Result>(_repository, _currentUser);
        RequestHandlerDelegate<Result> next = (ct) => Task.FromResult(Result.Failure("error"));

        await behavior.Handle(new CommandWithAttribute(), next, CancellationToken.None);

        await _repository.DidNotReceive().AddAsync(Arg.Any<UserAction>(), Arg.Any<CancellationToken>());
    }
}