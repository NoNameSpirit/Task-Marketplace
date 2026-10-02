using MediatR;
using Shared.Dtos.Responses;

namespace Application.Chats.Commands.AddMessage;

public record AddMessageCommand(
    Guid ChatId,
    string Text,
    Guid SenderId) : IRequest<Result>;
