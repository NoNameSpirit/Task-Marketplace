namespace Task_Marketplace.Shared.Dtos.Requests.ProjectTasks.Queries;

public record class GetByCustomerRequest(
    Guid CustomerId,
    int Page,
    int PageSize);