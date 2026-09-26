using Domain.Shared;
using MediatR;

namespace Application.Chats.Commands.AddMessage;

public record AddMessageCommand(
    Guid ChatId,
    string Text,
    Guid SenderId) : IRequest<Result>;
