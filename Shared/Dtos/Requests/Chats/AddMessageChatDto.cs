namespace Shared.Dtos.Requests.Chats;

public record class AddMessageChatDto(
    string Text,
    Guid SenderId);
