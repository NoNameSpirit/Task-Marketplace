using Application.Users.Commands.Delete;
using Application.Users.Commands.Update;
using Application.Users.Queries.GetAll;
using Application.Users.Queries.GetById;
using Application.Users.Queries.SearchByName;
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
public class UserController : ControllerBase
{
    private readonly IMediator _mediatr;

    public UserController(IMediator mediatr)
    {
        _mediatr = mediatr;
    }

    [Authorize(Roles = (nameof(UserRole.Admin)))]
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(
        Guid id)
    {
        var command = new DeleteUserCommand(id);

        var result = await _mediatr.Send(command);

        return result.ToResponse(this);
    }

    [Authorize(Roles = (nameof(UserRole.Admin)))]
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(
        Guid id,
        [FromBody] UpdateUserDto request)
    {
        var command = new UpdateUserCommand(
            id,
            request.Name);

        var result = await _mediatr.Send(command);

        return result.ToResponse(this);
    }

    [Authorize]
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(
        Guid id)
    {
        var query = new GetUserByIdQuery(id);

        var result = await _mediatr.Send(query);

        return result.ToResponse(this);
    }

    [Authorize(Roles = (nameof(UserRole.Admin)))]
    [HttpGet("search")]
    public async Task<IActionResult> GetByName(
        [FromQuery] string name,
        [FromQuery] PageDto request)
    {
        var query = new SearchUsersQuery(
            name,
            request.Page,
            request.PageSize);

        var result = await _mediatr.Send(query);

        return result.ToResponse(this);
    }

    [Authorize(Roles = (nameof(UserRole.Admin)))]
    [HttpGet("all")]
    public async Task<IActionResult> GetAll(
        [FromQuery] PageDto request)
    {
        var query = new GetAllUsersQuery(
            request.Page,
            request.PageSize);

        var result = await _mediatr.Send(query);

        return result.ToResponse(this);
    }
}
