namespace Shared.Dtos.Responses.Chats;

public record class ChatDto(
    Guid Id,
    Guid ProjectTaskId,
    List<MessageDto> Messages);
