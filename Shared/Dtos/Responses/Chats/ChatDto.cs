namespace Shared.Dtos.Responses.Chats;

public class ChatDto
{
    public Guid Id { get; set; }
    public Guid ProjectTaskId { get; set; }
    public List<MessageDto> Messages { get; set; } = new();

    public ChatDto() { }

    public ChatDto(
        Guid id,
        Guid projectTaskId,
        List<MessageDto> messages)
    {
        Id = id;
        ProjectTaskId = projectTaskId;
        Messages = messages;
    }
}