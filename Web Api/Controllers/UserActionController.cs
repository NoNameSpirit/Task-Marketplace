using Application.UserActions.Queries.GetUserActions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos.Requests;
using Shared.Enums;
using Web_Api.Extensions;

namespace Web_Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = nameof(UserRole.Admin))]
public class UserActionController : ControllerBase
{
    private readonly IMediator _mediatr;

    public UserActionController(IMediator mediatr)
    {
        _mediatr = mediatr;
    }

    [HttpGet]
    public async Task<IActionResult> Get(
        [FromQuery] Guid? userId,
        [FromQuery] int? actionType,
        [FromQuery] PageDto request)
    {
        var query = new GetUserActionsQuery(
            userId,
            actionType,
            request.Page,
            request.PageSize);

        var result = await _mediatr.Send(query);

        return result.ToResponse(this);
    }
}