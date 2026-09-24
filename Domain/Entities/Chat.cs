namespace Domain.Entities;

public class Chat : Entity
{
    public Guid ProjectTaskId { get; set; }

    public ICollection<Message> Messages { get; set; } = null!;
}
