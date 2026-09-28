using MediatR;
using Shared.Dtos;
using Shared.Dtos.Chats;

namespace Application.Chats.Queries.GetById;

public record GetChatByIdQuery(
    Guid ChatId) : IRequest<Result<ChatDto>>;
