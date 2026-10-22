using Shared.Dtos.Responses;

namespace Domain.Entities;

public class TaskResponse : Entity
{
    public Guid TaskId { get; private set; }
    public Guid ExecutorId { get; private set; }
    public DateTimeOffset RespondedAt { get; private set; }
    public ProjectTask Task { get; private set; } = null!;

    private TaskResponse() { }

    public static Result<TaskResponse> Create(
        Guid taskId,
        Guid executorId)
    {
        var taskResponse = new TaskResponse
        {
            Id = Guid.NewGuid(),
            TaskId = taskId,
            ExecutorId = executorId,
            RespondedAt = DateTimeOffset.UtcNow
        };

        return Result<TaskResponse>.Success(taskResponse);
    }
}
