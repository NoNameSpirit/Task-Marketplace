namespace Shared.Dtos.Responses.ProjectTasks;

public record class TaskResponseDto
{
    public Guid ExecutorId { get; set; }
    public string ExecutorName { get; set; } = string.Empty;
    public DateTimeOffset RespondedAt { get; set; }
    public decimal? ExecutorRating { get; set; }
}
