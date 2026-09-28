using MediatR;
using Shared.Dtos.Chats;

namespace Application.Chats.Queries.GetWithMessages;

public record GetChatWithMessagesQuery(
    Guid ChatId) : IRequest<ChatDto?>;