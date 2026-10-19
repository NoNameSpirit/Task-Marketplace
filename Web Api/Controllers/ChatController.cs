using Application.Chats.Commands.AddMessage;
using Application.Chats.Commands.Create;
using Application.Chats.Commands.Delete;
using Application.Chats.Queries.GetById;
using Application.Chats.Queries.GetByTaskId;
using Application.Chats.Queries.GetWithMessages;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos.Requests.Chats;
using Shared.Enums;
using Web_Api.Extensions;

namespace Web_Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class ChatController : ControllerBase
{
    private readonly IMediator _mediatr;

    public ChatController(IMediator mediatr)
    {
        _mediatr = mediatr;
    }

    [HttpPost]
    public async Task<IActionResult> Create(
        [FromQuery] Guid projectTaskId,
        CancellationToken cancellationToken)
    {
        var command = new CreateChatCommand(projectTaskId);

        var result = await _mediatr.Send(command, cancellationToken);

        if (!result.IsSuccess)
        {
            return result.ToResponse(this);
        }

        return CreatedAtAction(nameof(GetById), new { id = result.Value!.Id }, result.Value);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = $"{nameof(UserRole.Customer)},{nameof(UserRole.Admin)}")]
    public async Task<IActionResult> Delete(
        Guid id,
        CancellationToken cancellationToken)
    {
        var command = new DeleteChatCommand(id);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpPost("{id}/messages")]
    public async Task<IActionResult> AddMessage(
        Guid id,
        [FromBody] AddMessageChatDto request,
        CancellationToken cancellationToken)
    {
        var command = new AddMessageCommand(id, request.Text);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(
        Guid id,
        CancellationToken cancellationToken)
    {
        var query = new GetChatByIdQuery(id);

        var result = await _mediatr.Send(query, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpGet("task/{id}")]
    public async Task<IActionResult> GetByTaskId(
        Guid id,
        CancellationToken cancellationToken)
    {
        var query = new GetChatByTaskIdQuery(id);

        var result = await _mediatr.Send(query, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpGet("{id}/messages")]
    public async Task<IActionResult> GetAll(
        Guid id,
        CancellationToken cancellationToken)
    {
        var query = new GetChatWithMessagesQuery(id);

        var result = await _mediatr.Send(query, cancellationToken);

        return result.ToResponse(this);
    }
}