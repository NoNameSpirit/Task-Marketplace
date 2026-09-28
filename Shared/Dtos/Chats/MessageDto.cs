namespace Shared.Dtos.Chats;

public record class MessageDto(
    Guid Id,
    Guid UserId,
    string Text);
