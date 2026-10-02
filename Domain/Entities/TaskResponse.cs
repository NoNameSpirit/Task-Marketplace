namespace Domain.Entities;

public class TaskResponse : Entity
{
    public Guid TaskId { get; private set; }
    public Guid ExecutorId { get; private set; }
    public DateTimeOffset RespondedAt { get; private set; }
    public ProjectTask Task { get; private set; } = null!;

    private TaskResponse() { }

    public static TaskResponse Create(
        Guid taskId,
        Guid executorId)
    {
        return new TaskResponse
        {
            Id = Guid.NewGuid(),
            TaskId = taskId,
            ExecutorId = executorId,
            RespondedAt = DateTimeOffset.UtcNow
        };
    }
}
