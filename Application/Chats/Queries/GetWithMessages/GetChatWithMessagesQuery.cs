using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;

namespace Application.Chats.Queries.GetWithMessages;

public record GetChatWithMessagesQuery(
    Guid ChatId) : IRequest<Result<ChatDto>>;