namespace Shared.Dtos.Chats;

public record class ChatDto(
    Guid Id,
    List<MessageDto> Messages);
