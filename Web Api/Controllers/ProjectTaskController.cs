using Application.ProjectTasks.Commands.AssignExecutor;
using Application.ProjectTasks.Commands.Create;
using Application.ProjectTasks.Commands.DeleteProjectTask;
using Application.ProjectTasks.Commands.MarkAsDone;
using Application.ProjectTasks.Commands.RespondToTask;
using Application.ProjectTasks.Commands.Update;
using Application.ProjectTasks.Queries.GetProjectTaskById;
using Application.ProjectTasks.Queries.GetPublishedTasks;
using Application.ProjectTasks.Queries.GetTasksByCustomer;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web_Api.Dtos;
using Web_Api.Dtos.ProjectTasks;
using Web_Api.Extensions;

namespace Web_Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectTaskController : ControllerBase
{
    private readonly IMediator _mediatr;

    public ProjectTaskController(IMediator mediatr)
    {
        _mediatr = mediatr;
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Create(
        [FromBody] CreateProjectTaskDto request)
    {
        var command = new CreateProjectTaskCommand(
            request.Title,
            request.Description,
            request.Price,
            request.StartsAt,
            request.EndsAt,
            request.CustomerId);

        var result = await _mediatr.Send(command);

        if (!result.IsSuccess)
        {
            return BadRequest(new { error = result.Message });
        }

        return CreatedAtAction(nameof(GetById), new { id = result.Value!.Id }, result.Value);
    }

    [Authorize]
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(
        Guid id)
    {
        var command = new DeleteProjectTaskCommand(id);

        var result = await _mediatr.Send(command);

        return result.ToResponse(this);
    }

    [Authorize]
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(
        Guid id,
        [FromBody] UpdateProjectTaskDto request)
    {
        var command = new UpdateProjectTaskCommand(
            id,
            request.Title,
            request.Description,
            request.Price,
            request.StartsAt,
            request.EndsAt,
            request.CustomerId);

        var result = await _mediatr.Send(command);

        return result.ToResponse(this);
    }

    [Authorize]
    [HttpPost("{id}/respond")]
    public async Task<IActionResult> Respond(
        Guid id,
        [FromBody] RespondToTaskProjectTaskDto request)
    {
        var command = new RespondToTaskCommand(
            id,
            request.ExecutorId);

        var result = await _mediatr.Send(command);

        return result.ToResponse(this);
    }

    [Authorize]
    [HttpPost("{id}/mark-as-done")]
    public async Task<IActionResult> MarkAsDone(
        Guid id)
    {
        var command = new MarkAsDoneCommand(id);

        var result = await _mediatr.Send(command);

        return result.ToResponse(this);
    }

    [Authorize]
    [HttpPost("{id}/assign")]
    public async Task<IActionResult> Assign(
        Guid id,
        [FromBody] AssignProjectTaskDto request)
    {
        var command = new AssignExecutorCommand(
            id,
            request.ExecutorId,
            request.CustomerId);

        var result = await _mediatr.Send(command);

        return result.ToResponse(this);
    }

    [Authorize]
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(
        Guid id)
    {
        var query = new GetProjectTaskByIdQuery(id);

        var result = await _mediatr.Send(query);

        return result.ToResponse(this);
    }

    [Authorize]
    [HttpGet("customer/{customerId}")]
    public async Task<IActionResult> GetByCustomer(
        Guid customerId,
        [FromQuery] PageDto request)
    {
        var query = new GetTasksByCustomerQuery(
            customerId,
            request.Page,
            request.PageSize);

        var result = await _mediatr.Send(query);

        return result.ToResponse(this);
    }

    [Authorize]
    [HttpGet("published")]
    public async Task<IActionResult> GetPublished(
        [FromQuery] PageDto request)
    {
        var query = new GetPublishedTasksQuery(
            request.Page,
            request.PageSize);

        var result = await _mediatr.Send(query);

        return result.ToResponse(this);
    }
}
