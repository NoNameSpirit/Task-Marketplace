using MediatR;
using Shared.Dtos.Responses;

namespace Application.Chats.Commands.Delete;

public record DeleteChatCommand(
    Guid ChatId) : IRequest<Result>;
