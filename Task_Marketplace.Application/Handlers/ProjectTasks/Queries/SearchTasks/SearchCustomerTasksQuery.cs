namespace Task_Marketplace.Application.Handlers.ProjectTasks.Queries.SearchTasks;

public record SearchCustomerTasksQuery(
    Guid CustomerId,
    string Query,
    int Page,
    int PageSize) : ISearchTasksQuery;