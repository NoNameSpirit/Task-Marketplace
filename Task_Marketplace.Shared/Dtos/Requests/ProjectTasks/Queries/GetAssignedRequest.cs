namespace Task_Marketplace.Shared.Dtos.Requests.ProjectTasks.Queries;

public record class GetAssignedRequest(
    Guid ExecutorId,
    int Page,
    int PageSize);
