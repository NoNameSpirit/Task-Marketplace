using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.UserActions;
using Shared.Enums;
using System.Security.Claims;
using Task_Marketplace.Application.Handlers.UserActions.Queries.GetUserActions;
using Task_Marketplace.Shared.Dtos.Requests.UserActions.Queries;

namespace Web_Api.Controllers.UserActions;

public class GetEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<GetUserActionsRequest, PagedResult<UserActionDto>>
{
    public override void Configure()
    {
        Get(string.Empty);
        Group<UserActionGroup>();
        Claims(ClaimTypes.NameIdentifier);
        Roles(nameof(UserRole.Admin));
    }

    public override async Task HandleAsync(
        GetUserActionsRequest request,
        CancellationToken cancellationToken = default)
    {
        var query = new GetUserActionsQuery(
            request.UserId,
            request.ActionType,
            request.Page,
            request.PageSize);

        var result = await _mediatr.Send(query, cancellationToken);

        if (await SendIfFailureAsync(result, cancellationToken))
        {
            return;
        }

        await Send.OkAsync(result.Value!, cancellationToken);
    }
}