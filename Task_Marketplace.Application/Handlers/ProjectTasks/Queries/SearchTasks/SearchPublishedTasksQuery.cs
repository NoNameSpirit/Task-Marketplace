namespace Task_Marketplace.Application.Handlers.ProjectTasks.Queries.SearchTasks;

public record SearchPublishedTasksQuery(
    string Query,
    int Page,
    int PageSize) : ISearchTasksQuery;