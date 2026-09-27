using Domain.Entities;
using Domain.Shared;
using MediatR;

namespace Application.Chats.Queries.GetByTaskId;

public record GetChatByTaskIdQuery(
    Guid TaskId) : IRequest<Result<Chat>>;
