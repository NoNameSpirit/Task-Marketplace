using Shared.Enums;

namespace Shared.Dtos.Responses.ProjectTasks;

public record class ProjectTaskDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public ProjectTaskStatus Status { get; set; }
    public DateTimeOffset StartsAt { get; set; }
    public DateTimeOffset EndsAt { get; set; }
    public bool IsRespondedByCurrentUser { get; set; }
    public decimal? ProjectRating { get; set; }

    public ProjectTaskDto() { }

    public ProjectTaskDto(
        Guid id,
        string title,
        string description,
        decimal price,
        ProjectTaskStatus status,
        DateTimeOffset startsAt,
        DateTimeOffset endsAt,
        bool isRespondedByCurrentUser,
        decimal? projectRating)
    {
        Id = id;
        Title = title;
        Description = description;
        Price = price;
        Status = status;
        StartsAt = startsAt;
        EndsAt = endsAt;
        IsRespondedByCurrentUser = isRespondedByCurrentUser;
        ProjectRating = projectRating;
    }
}
