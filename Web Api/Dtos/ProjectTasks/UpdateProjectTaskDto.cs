namespace Web_Api.Dtos.ProjectTasks;

public record class UpdateProjectTaskDto(
    string Title,
    string Description,
    decimal Price,
    DateTimeOffset StartsAt,
    DateTimeOffset EndsAt,
    Guid CustomerId);
