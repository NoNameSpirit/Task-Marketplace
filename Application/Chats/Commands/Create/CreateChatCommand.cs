using MediatR;
using Shared.Dtos;
using Shared.Dtos.Chats;

namespace Application.Chats.Commands.Create;

public record CreateChatCommand(
    Guid ProjectTaskId) : IRequest<Result<ChatDto>>;
