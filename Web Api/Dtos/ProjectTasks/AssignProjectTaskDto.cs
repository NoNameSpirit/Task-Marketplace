namespace Web_Api.Dtos.ProjectTasks;

public record class AssignProjectTaskDto(
    Guid ExecutorId,
    Guid CustomerId);
