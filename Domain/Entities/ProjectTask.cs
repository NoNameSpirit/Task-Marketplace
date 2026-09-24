namespace Domain.Entities;

public class ProjectTask : Entity
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; } = decimal.Zero;
    public TaskStatus Status { get; set; }
    public DateTimeOffset StartsAt { get; set; }
    public DateTimeOffset EndsAt { get; set; }

    public Guid CustomerId { get; set; }
    public Guid? ExecutorId { get; set; }
    public decimal? ProjectRating { get; set; }

    public List<Guid> RespondentIds { get; set; } = new();
}
