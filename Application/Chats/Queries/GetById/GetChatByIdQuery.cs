using Domain.Entities;
using MediatR;

namespace Application.Chats.Queries.GetById;

public record GetChatByIdQuery(
    Guid ChatId) : IRequest<Chat?>;
