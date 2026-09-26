using Domain.Entities;
using MediatR;

namespace Application.Chats.Queries.GetByTaskId;

public record GetChatByTaskIdQuery(
    Guid TaskId) : IRequest<Chat?>;
