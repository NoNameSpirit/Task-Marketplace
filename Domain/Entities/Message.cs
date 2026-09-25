namespace Domain.Entities;

public class Message : Entity
{
    public string Text { get; private set; } = string.Empty;
    public Guid UserId { get; private set; }
    public Guid ChatId { get; private set; }

    private Message() { }

    internal Message(string text, Guid userId, Guid chatId)
    {
        Text = text;
        UserId = userId;
        ChatId = chatId;
        Id = Guid.NewGuid();
    }
}
