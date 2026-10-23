using Application.Behaviors;
using Domain.Interfaces;
using FluentAssertions;
using MediatR;
using NSubstitute;
using Shared.Dtos.Responses;
using Xunit;

namespace Task_Marketplace.Tests.Application.Behaviors;

public class TransactionBehaviourTests
{
    private IUnitOfWork _unitOfWork = Substitute.For<IUnitOfWork>();
    private TransactionBehaviour<CustomCommand, Result> _behaviour;

    private record CustomCommand : IRequest<Result>;
    public record FakeQuery : IRequest<Result>;

    public TransactionBehaviourTests()
    {
        _behaviour = new TransactionBehaviour<CustomCommand, Result>(_unitOfWork);
    }

    [Fact]
    public async Task Handle_CommandWithSuccess_ShouldCallSaveChanges()
    {
        var expectedResult = Result.Success();
        RequestHandlerDelegate<Result> next = (cancellationToken) => Task.FromResult(expectedResult);

        var response = await _behaviour.Handle(new CustomCommand(), next, CancellationToken.None);

        response.Should().Be(expectedResult);
        await _unitOfWork.Received(1).SaveChangesAsync(Arg.Any<CancellationToken>());
    }

    [Fact]
    public async Task Handle_CommandWithFailure_ShouldNotCallSaveChanges()
    {
        var expectedResult = Result.Failure("error");
        RequestHandlerDelegate<Result> next = (cancellationToken) => Task.FromResult(expectedResult);

        var response = await _behaviour.Handle(new CustomCommand(), next, CancellationToken.None);

        await _unitOfWork.DidNotReceive().SaveChangesAsync(Arg.Any<CancellationToken>());
    }

    [Fact]
    public async Task Handle_Query_ShouldNotCallSaveChanges()
    {
        var behaviour = new TransactionBehaviour<FakeQuery, Result>(_unitOfWork);
        RequestHandlerDelegate<Result> next = (ct) => Task.FromResult(Result.Success());

        await behaviour.Handle(new FakeQuery(), next, CancellationToken.None);

        await _unitOfWork.DidNotReceive().SaveChangesAsync(Arg.Any<CancellationToken>());
    }
}
