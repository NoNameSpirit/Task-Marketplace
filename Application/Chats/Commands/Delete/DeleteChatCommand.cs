using MediatR;
using Shared.Dtos;

namespace Application.Chats.Commands.Delete;

public record DeleteChatCommand(
    Guid ChatId) : IRequest<Result>;
