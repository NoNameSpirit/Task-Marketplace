using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Task_Marketplace.Application.Handlers.Chats.Commands.Delete;

[LogAction(UserActionType.DeletedChat, nameof(Chat))]
public record DeleteChatCommand(
    Guid ChatId) : IRequest<Result>;