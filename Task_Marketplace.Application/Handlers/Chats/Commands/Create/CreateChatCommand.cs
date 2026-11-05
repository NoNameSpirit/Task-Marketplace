using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;
using Shared.Enums;
using Task_Marketplace.Application.Attributes;

namespace Task_Marketplace.Application.Handlers.Chats.Commands.Create;

[LogAction(UserActionType.CreatedChat, nameof(Chat))]
public record CreateChatCommand(
    Guid ProjectTaskId) : IRequest<Result<ChatDto>>;