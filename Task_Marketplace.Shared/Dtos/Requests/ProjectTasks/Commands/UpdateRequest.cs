namespace Task_Marketplace.Shared.Dtos.Requests.ProjectTasks.Commands;

public record class UpdateRequest(
    string Title,
    string Description,
    decimal Price,
    DateTimeOffset StartsAt,
    DateTimeOffset EndsAt);
