using Application.Chats.Commands.AddMessage;
using Application.Chats.Commands.Create;
using Application.Chats.Commands.Delete;
using Application.Chats.Queries.GetById;
using Application.Chats.Queries.GetByTaskId;
using Application.Chats.Queries.GetWithMessages;
using Domain.Enums.User;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web_Api.Dtos.Chats;

namespace Web_Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChatController : ControllerBase
{
    private readonly IMediator _mediatr;

    public ChatController(IMediator mediatr)
    {
        _mediatr = mediatr;
    }

    [HttpPost]
    [Authorize(Roles = $"{nameof(UserRole.Customer)},{nameof(UserRole.Admin)}")]
    public async Task<IActionResult> Create(
        Guid projectTaskId)
    {
        var command = new CreateChatCommand(
            projectTaskId);

        var result = await _mediatr.Send(command);

        if (!result.IsSuccess)
        {
            return BadRequest(new { error = result.Message });
        }

        return CreatedAtAction(nameof(GetById), new { id = result.Value!.Id }, result.Value);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = $"{nameof(UserRole.Customer)},{nameof(UserRole.Admin)}")]
    public async Task<IActionResult> Delete(
        Guid id)
    {
        var command = new DeleteChatCommand(id);

        var result = await _mediatr.Send(command);

        if (!result.IsSuccess)
        {
            return NotFound(new { error = result.Message });
        }

        return NoContent();
    }

    [HttpPost("{id}/messages")]
    [Authorize(Roles = $"{nameof(UserRole.Customer)},{nameof(UserRole.Executor)}")]
    public async Task<IActionResult> AddMessage(
        Guid id,
        [FromBody] AddMessageChatDto request)
    {
        var command = new AddMessageCommand(
            id,
            request.Text,
            request.SenderId);

        var result = await _mediatr.Send(command);

        if (!result.IsSuccess)
        {
            return BadRequest(new { error = result.Message });
        }

        return NoContent();
    }

    [HttpGet("{id}")]
    [Authorize(Roles = $"{nameof(UserRole.Customer)},{nameof(UserRole.Executor)},{nameof(UserRole.Admin)}")]
    public async Task<IActionResult> GetById(
        Guid id)
    {
        var query = new GetChatByIdQuery(id);

        var result = await _mediatr.Send(query);

        if (!result.IsSuccess)
        {
            return NotFound(new { error = result.Message });
        }

        return Ok(result);
    }

    [HttpGet("task/{id}")]
    [Authorize(Roles = $"{nameof(UserRole.Customer)},{nameof(UserRole.Executor)},{nameof(UserRole.Admin)}")]
    public async Task<IActionResult> GetByTaskId(
        Guid id)
    {
        var query = new GetChatByTaskIdQuery(id);

        var result = await _mediatr.Send(query);

        if (!result.IsSuccess)
        {
            return NotFound(new { error = result.Message });
        }

        return Ok(result);
    }

    [HttpGet("{id}/messages")]
    [Authorize(Roles = $"{nameof(UserRole.Customer)},{nameof(UserRole.Executor)},{nameof(UserRole.Admin)}")]
    public async Task<IActionResult> GetAll(
        Guid id)
    {
        var query = new GetChatWithMessagesQuery(id);

        var result = await _mediatr.Send(query);

        return Ok(result);
    }
}
