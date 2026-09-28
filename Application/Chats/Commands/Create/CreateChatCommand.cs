using Domain.Entities;
using MediatR;
using Shared.Dtos;

namespace Application.Chats.Commands.Create;

public record CreateChatCommand(
    Guid ProjectTaskId) : IRequest<Result<Chat>>;
