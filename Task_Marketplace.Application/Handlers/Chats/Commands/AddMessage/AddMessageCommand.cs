using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;
using Task_Marketplace.Application.Attributes;

namespace Task_Marketplace.Application.Handlers.Chats.Commands.AddMessage;

[LogAction(UserActionType.SentMessage, nameof(Chat))]
public record AddMessageCommand(
    Guid ChatId,
    string Text) : IRequest<Result>;