using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;

namespace Application.Chats.Queries.GetByTaskId;

public record GetChatByTaskIdQuery(
    Guid TaskId) : IRequest<Result<ChatDto>>;