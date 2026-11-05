using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;

namespace Task_Marketplace.Application.Handlers.Chats.Queries.GetById;

public record GetChatByIdQuery(
    Guid ChatId) : IRequest<Result<ChatDto>>;
