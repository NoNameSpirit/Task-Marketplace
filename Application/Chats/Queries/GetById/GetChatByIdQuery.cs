using Domain.Entities;
using Domain.Shared;
using MediatR;

namespace Application.Chats.Queries.GetById;

public record GetChatByIdQuery(
    Guid ChatId) : IRequest<Result<Chat>>;
