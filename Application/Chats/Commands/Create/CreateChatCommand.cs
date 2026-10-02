using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;

namespace Application.Chats.Commands.Create;

public record CreateChatCommand(
    Guid ProjectTaskId) : IRequest<Result<ChatDto>>;
