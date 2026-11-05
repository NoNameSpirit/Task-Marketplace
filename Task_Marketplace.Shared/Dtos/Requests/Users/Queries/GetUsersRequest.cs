namespace Task_Marketplace.Shared.Dtos.Requests.Users.Queries;

public record class GetUsersRequest(
    int Page,
    int PageSize);