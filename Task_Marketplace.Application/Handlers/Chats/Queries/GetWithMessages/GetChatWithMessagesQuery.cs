using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;

namespace Task_Marketplace.Application.Handlers.Chats.Queries.GetWithMessages;

public record GetChatWithMessagesQuery(
    Guid ChatId) : IRequest<Result<ChatDto>>;