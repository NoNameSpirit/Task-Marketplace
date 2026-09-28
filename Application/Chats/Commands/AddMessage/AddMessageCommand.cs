using MediatR;
using Shared.Dtos;

namespace Application.Chats.Commands.AddMessage;

public record AddMessageCommand(
    Guid ChatId,
    string Text,
    Guid SenderId) : IRequest<Result>;
