using MediatR;
using Shared.Dtos;
using Shared.Dtos.Chats;

namespace Application.Chats.Queries.GetByTaskId;

public record GetChatByTaskIdQuery(
    Guid TaskId) : IRequest<Result<ChatDto>>;
