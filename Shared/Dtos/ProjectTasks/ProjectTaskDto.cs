using Shared.Enums;

namespace Shared.Dtos.ProjectTasks;

public record class ProjectTaskDto(
    Guid Id,
    string Title,
    string Description,
    decimal Price,
    ProjectTaskStatus Status,
    DateTimeOffset StartsAt,
    DateTimeOffset EndsAt);
