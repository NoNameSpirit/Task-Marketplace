namespace Task_Marketplace.Shared.Dtos.Requests.UserActions.Queries;

public record class GetUserActionsRequest(
    Guid? UserId,
    int? ActionType,
    int Page,
    int PageSize);