using Domain.Entities;
using Domain.Shared;
using MediatR;

namespace Application.Chats.Commands.Create;

public record CreateChatCommand(
    Guid ProjectTaskId) : IRequest<Result<Chat>>;
