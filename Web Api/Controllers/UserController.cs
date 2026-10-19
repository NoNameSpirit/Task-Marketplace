using Application.Users.Commands.BlockUser;
using Application.Users.Commands.ChangeRole;
using Application.Users.Commands.Delete;
using Application.Users.Commands.UnblockUser;
using Application.Users.Queries.GetUsers;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos.Requests;
using Shared.Dtos.Requests.Users;
using Shared.Enums;
using Web_Api.Extensions;

namespace Web_Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = nameof(UserRole.Admin))]
public class UserController : ControllerBase
{
    private readonly IMediator _mediatr;

    public UserController(IMediator mediatr)
    {
        _mediatr = mediatr;
    }

    [HttpGet]
    public async Task<IActionResult> Get(
        [FromQuery] PageDto request,
        CancellationToken cancellationToken)
    {
        var query = new GetUsersQuery(request.Page, request.PageSize);

        var result = await _mediatr.Send(query, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpPatch("{id}/role")]
    public async Task<IActionResult> ChangeRole(
        Guid id,
        [FromBody] ChangeRoleUserDto request,
        CancellationToken cancellationToken)
    {
        var command = new ChangeRoleCommand(id, request.NewRole);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpPost("{id}/block")]
    public async Task<IActionResult> Block(
        Guid id,
        CancellationToken cancellationToken)
    {
        var command = new BlockUserCommand(id);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpPost("{id}/unblock")]
    public async Task<IActionResult> Unblock(
        Guid id,
        CancellationToken cancellationToken)
    {
        var command = new UnblockUserCommand(id);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(
        Guid id,
        CancellationToken cancellationToken)
    {
        var command = new DeleteUserCommand(id);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }
}