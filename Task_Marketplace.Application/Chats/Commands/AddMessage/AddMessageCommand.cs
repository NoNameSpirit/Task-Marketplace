using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Chats.Commands.AddMessage;

[LogAction(UserActionType.SentMessage, nameof(Chat))]
public record AddMessageCommand(
    Guid ChatId,
    string Text) : IRequest<Result>;