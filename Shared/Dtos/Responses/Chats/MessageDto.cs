namespace Shared.Dtos.Responses.Chats;

public class MessageDto
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public DateTimeOffset SentAt { get; set; }

    public MessageDto() { }

    public MessageDto(
        Guid id,
        Guid userId,
        string userName,
        string text,
        DateTimeOffset sentAt)
    {
        Id = id;
        UserId = userId;
        Text = text;
        SentAt = sentAt;
        UserName = userName;
    }
}