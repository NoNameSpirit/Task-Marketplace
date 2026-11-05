using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;

namespace Task_Marketplace.Application.Handlers.Chats.Queries.GetByTaskId;

public record GetChatByTaskIdQuery(
    Guid TaskId) : IRequest<Result<ChatDto>>;