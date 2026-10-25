using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.Chats;
using FluentAssertions;
using NSubstitute;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;
using Shared.Enums;
using Task_Marketplace.Application.Handlers.Chats.Queries.GetById;
using Xunit;

namespace Task_Marketplace.Tests.Application.Chats.Queries.GetById;

public class GetChatByIdHandlerTests
{
    private readonly IChatQueryRepository _queryRepository = Substitute.For<IChatQueryRepository>();
    private readonly GetChatByIdHandler _handler;

    private readonly Guid _chatId = Guid.NewGuid();

    public GetChatByIdHandlerTests()
    {
        _handler = new GetChatByIdHandler(_queryRepository);
    }

    [Fact]
    public async Task Handle_ChatIsNull_ReturnFailure()
    {
        var query = new GetChatByIdQuery(_chatId);
        var expectedResult = Result<ChatDto>.Failure(ErrorMessages.ChatNotFound, ErrorType.NotFound);

        _queryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns((Chat?)null);

        var result = await _handler.Handle(query, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var query = new GetChatByIdQuery(_chatId);
        var chat = Chat.Create(Guid.NewGuid()).Value!;

        _queryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(chat);

        _queryRepository
             .GetUserNamesAsync(Arg.Any<IEnumerable<Guid>>(), Arg.Any<CancellationToken>())
             .Returns(new Dictionary<Guid, string>());

        var result = await _handler.Handle(query, CancellationToken.None);

        result.IsSuccess.Should().BeTrue();
    }
}