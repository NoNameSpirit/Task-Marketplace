using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.UserActions;

namespace Task_Marketplace.Application.Handlers.UserActions.Queries.GetUserActions;

public record GetUserActionsQuery(
    Guid? UserId,
    int? ActionType,
    int Page,
    int PageSize) : IRequest<Result<PagedResult<UserActionDto>>>;