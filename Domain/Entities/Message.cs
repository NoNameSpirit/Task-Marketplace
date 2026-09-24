namespace Domain.Entities;

public class Message : Entity
{
    public string Text { get; set; } = string.Empty;
    public Guid UserId { get; set; }
    public Guid ChatId { get; set; }
}
