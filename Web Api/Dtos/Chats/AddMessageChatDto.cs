namespace Web_Api.Dtos.Chats;

public record class AddMessageChatDto(
    string Text,
    Guid SenderId);
