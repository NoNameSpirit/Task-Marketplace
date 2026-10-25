namespace Task_Marketplace.Shared.Dtos.Requests.ProjectTasks.Queries;

public record class SearchRequest(
    string Query,
    int Page,
    int PageSize);