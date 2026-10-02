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
using System.Security.Claims;
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
        [FromQuery] PageDto request)
    {
        var query = new GetUsersQuery(
            request.Page,
            request.PageSize);

        var result = await _mediatr.Send(query);

        return result.ToResponse(this);
    }

    [HttpPatch("{id}/role")]
    public async Task<IActionResult> ChangeRole(
        Guid id,
        [FromBody] ChangeRoleUserDto request)
    {
        var currentUserId = Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value!);

        var command = new ChangeRoleCommand(
            id,
            request.NewRole,
            currentUserId);

        var result = await _mediatr.Send(command);

        return result.ToResponse(this);
    }

    [HttpPost("{id}/block")]
    public async Task<IActionResult> Block(
        Guid id)
    {
        var currentUserId = Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value!);

        var command = new BlockUserCommand(
            id,
            currentUserId);

        var result = await _mediatr.Send(command);

        return result.ToResponse(this);
    }

    [HttpPost("{id}/unblock")]
    public async Task<IActionResult> Unblock(
        Guid id)
    {
        var currentUserId = Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value!);

        var command = new UnblockUserCommand(
            id,
            currentUserId);

        var result = await _mediatr.Send(command);

        return result.ToResponse(this);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(
        Guid id)
    {
        var currentUserId = Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value!);

        var command = new DeleteUserCommand(
            id,
            currentUserId);

        var result = await _mediatr.Send(command);

        return result.ToResponse(this);
    }
}