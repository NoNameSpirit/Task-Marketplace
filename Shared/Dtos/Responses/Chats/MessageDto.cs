namespace Shared.Dtos.Responses.Chats;

public record class MessageDto(
    Guid Id,
    Guid UserId,
    string Text,
    DateTimeOffset SentAt);
