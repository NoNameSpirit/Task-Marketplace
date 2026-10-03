namespace Application.ProjectTasks.Queries.SearchTasks;

public record SearchPublishedTasksQuery(
    string Query,
    int Page,
    int PageSize,
    Guid CurrentUserId) : ISearchTasksQuery;