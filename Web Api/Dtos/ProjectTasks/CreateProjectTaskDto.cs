namespace Web_Api.Dtos.ProjectTasks;

public record class CreateProjectTaskDto(string Title,
    string Description,
    decimal Price,
    DateTimeOffset StartsAt,
    DateTimeOffset EndsAt,
    Guid CustomerId);