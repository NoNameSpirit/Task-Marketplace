namespace Application.ProjectTasks.Queries.SearchTasks;

public class SearchTasksQueryFactory
{
    public static ISearchTasksQuery Create(
        Guid currentUserId,
        bool isCustomer,
        string query,
        int page,
        int pageSize)
    {
        return isCustomer
            ? new SearchCustomerTasksQuery(currentUserId, query, page, pageSize)
            : new SearchPublishedTasksQuery(query, page, pageSize, currentUserId);
    }
}