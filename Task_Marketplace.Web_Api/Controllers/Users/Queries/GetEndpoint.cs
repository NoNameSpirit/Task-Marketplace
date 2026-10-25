using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using Shared.Enums;
using System.Security.Claims;
using Task_Marketplace.Application.Handlers.Users.Queries.GetUsers;
using Task_Marketplace.Shared.Dtos.Requests.Users.Queries;

namespace Web_Api.Controllers.Users;

public class GetEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<GetUsersRequest, PagedResult<UserDto>>
{
    public override void Configure()
    {
        Get(string.Empty);
        Group<UserGroup>();
        Claims(ClaimTypes.NameIdentifier);
        Roles(nameof(UserRole.Admin));
    }

    public override async Task HandleAsync(
        GetUsersRequest request,
        CancellationToken cancellationToken = default)
    {
        var query = new GetUsersQuery(request.Page, request.PageSize);

        var result = await _mediatr.Send(query, cancellationToken);

        if (await SendIfFailureAsync(result, cancellationToken))
        {
            return;
        }

        await Send.OkAsync(result.Value!, cancellationToken);
    }
}