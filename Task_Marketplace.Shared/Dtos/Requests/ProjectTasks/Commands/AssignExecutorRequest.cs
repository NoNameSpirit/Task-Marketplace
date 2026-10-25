namespace Task_Marketplace.Shared.Dtos.Requests.ProjectTasks.Commands;

public record class AssignExecutorRequest(
    Guid Id,
    decimal? Rating);
