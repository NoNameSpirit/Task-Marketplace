using Application.Users.Commands.CreateUser;
using Application.Users.Commands.Delete;
using Application.Users.Commands.Update;
using Application.Users.Queries.GetAll;
using Application.Users.Queries.GetById;
using Application.Users.Queries.SearchByName;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Enums;
using Web_Api.Dtos;
using Web_Api.Dtos.Users;

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

    [HttpPost]
    public async Task<IActionResult> Create(
        [FromBody] CreateUserDto request)
    {
        var command = new CreateUserCommand(
            request.Name,
            request.Role);

        var result = await _mediatr.Send(command);

        if (!result.IsSuccess)
        {
            return BadRequest(new { error = result.Message });
        }

        return CreatedAtAction(nameof(GetById), new { id = result.Value!.Id }, result.Value);
    }

    [Authorize(Roles = (nameof(UserRole.Admin)))]
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(
        Guid id)
    {
        var command = new DeleteUserCommand(id);

        var result = await _mediatr.Send(command);

        if (!result.IsSuccess)
        {
            return NotFound(new { error = result.Message });
        }

        return NoContent();
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

        if (!result.IsSuccess)
        {
            return BadRequest(new { error = result.Message });
        }

        return NoContent();
    }

    [Authorize]
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(
        Guid id)
    {
        var query = new GetUserByIdQuery(id);

        var result = await _mediatr.Send(query);

        if (!result.IsSuccess)
        {
            return NotFound(new { error = result.Message });
        }

        return Ok(result);
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

        if (!result.IsSuccess)
        {
            return NotFound(new { error = result.Message });
        }

        return Ok(result);
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

        return Ok(result);
    }
}
