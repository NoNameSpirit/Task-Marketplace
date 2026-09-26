using Domain.Entities;
using MediatR;

namespace Application.Chats.Queries.GetWithMessages;

public record GetChatWithMessagesQuery(
    Guid ChatId) : IRequest<Chat?>;