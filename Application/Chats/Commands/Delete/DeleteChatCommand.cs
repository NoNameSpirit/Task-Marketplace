using Domain.Shared;
using MediatR;

namespace Application.Chats.Commands.Delete;

public record DeleteChatCommand(
    Guid ChatId) : IRequest<Result>;
