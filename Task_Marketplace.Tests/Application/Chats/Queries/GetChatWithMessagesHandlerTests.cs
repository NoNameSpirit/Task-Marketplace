using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.Chats;
using FluentAssertions;
using NSubstitute;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;
using Shared.Enums;
using Task_Marketplace.Application.Handlers.Chats.Queries.GetWithMessages;
using Xunit;

namespace Task_Marketplace.Tests.Application.Chats.Queries.GetWithMessages;

public class GetChatWithMessagesHandlerTests
{
    private readonly IChatQueryRepository _queryRepository = Substitute.For<IChatQueryRepository>();
    private readonly GetChatWithMessagesHandler _handler;

    private readonly Guid _chatId = Guid.NewGuid();

    public GetChatWithMessagesHandlerTests()
    {
        _handler = new GetChatWithMessagesHandler(_queryRepository);
    }

    [Fact]
    public async Task Handle_ChatIsNull_ReturnFailure()
    {
        var query = new GetChatWithMessagesQuery(_chatId);
        var expectedResult = Result<ChatDto>.Failure(ErrorMessages.ChatNotFound, ErrorType.NotFound);

        _queryRepository
             .GetByIdWithMessagesAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns((Chat?)null);

        var result = await _handler.Handle(query, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var query = new GetChatWithMessagesQuery(_chatId);
        var chat = Chat.Create(Guid.NewGuid()).Value!;

        _queryRepository
             .GetByIdWithMessagesAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(chat);

        _queryRepository
             .GetUserNamesAsync(Arg.Any<IEnumerable<Guid>>(), Arg.Any<CancellationToken>())
             .Returns(new Dictionary<Guid, string>());

        var result = await _handler.Handle(query, CancellationToken.None);

        result.IsSuccess.Should().BeTrue();
    }
}