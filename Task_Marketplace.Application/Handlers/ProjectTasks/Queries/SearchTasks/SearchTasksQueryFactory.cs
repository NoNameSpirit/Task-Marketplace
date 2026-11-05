using Application.Interfaces;

namespace Task_Marketplace.Application.Handlers.ProjectTasks.Queries.SearchTasks;

public class SearchTasksQueryFactory
{
    public static ISearchTasksQuery Create(
        ICurrentUser currentUser,
        bool isCustomer,
        string query,
        int page,
        int pageSize)
    {
        return isCustomer
            ? new SearchCustomerTasksQuery(currentUser.Id, query, page, pageSize)
            : new SearchPublishedTasksQuery(query, page, pageSize);
    }
}