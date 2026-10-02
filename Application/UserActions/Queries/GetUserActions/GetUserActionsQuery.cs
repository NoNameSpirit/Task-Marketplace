using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.UserActions;

namespace Application.UserActions.Queries.GetUserActions;

public record GetUserActionsQuery(
    Guid? UserId,
    int? ActionType,
    int Page,
    int PageSize) : IRequest<Result<PagedResult<UserActionDto>>>;