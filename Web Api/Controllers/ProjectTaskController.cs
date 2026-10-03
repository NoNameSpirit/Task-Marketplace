using Application.ProjectTasks.Commands.AssignExecutor;
using Application.ProjectTasks.Commands.Cancel;
using Application.ProjectTasks.Commands.Create;
using Application.ProjectTasks.Commands.DeleteProjectTask;
using Application.ProjectTasks.Commands.MarkAsDone;
using Application.ProjectTasks.Commands.RespondToTask;
using Application.ProjectTasks.Commands.Update;
using Application.ProjectTasks.Queries.GetAssigned;
using Application.ProjectTasks.Queries.GetProjectTaskById;
using Application.ProjectTasks.Queries.GetPublishedTasks;
using Application.ProjectTasks.Queries.GetResponses;
using Application.ProjectTasks.Queries.GetTasksByCustomer;
using Application.ProjectTasks.Queries.SearchTasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos.Requests;
using Shared.Dtos.Requests.ProjectTasks;
using Shared.Enums;
using System.Security.Claims;
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
        var customerId = Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value!);

        var command = new CreateProjectTaskCommand(
            request.Title,
            request.Description,
            request.Price,
            request.StartsAt,
            request.EndsAt,
            customerId);

        var result = await _mediatr.Send(command);

        if (!result.IsSuccess)
        {
            return result.ToResponse(this);
        }

        return CreatedAtAction(nameof(GetById), new { id = result.Value!.Id }, result.Value);
    }

    [Authorize]
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(
        Guid id)
    {
        var userId = Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value!);

        var command = new DeleteProjectTaskCommand(id, userId);

        var result = await _mediatr.Send(command);

        return result.ToResponse(this);
    }

    [Authorize(Roles = nameof(UserRole.Customer))]
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(
        Guid id,
        [FromBody] UpdateProjectTaskDto request)
    {
        var customerId = Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value!);

        var command = new UpdateProjectTaskCommand(
            id,
            request.Title,
            request.Description,
            request.Price,
            request.StartsAt,
            request.EndsAt,
            customerId);

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

    [Authorize(Roles = nameof(UserRole.Customer))]
    [HttpPost("{id}/mark-as-done")]
    public async Task<IActionResult> MarkAsDone(
        Guid id,
        [FromBody] MarkAsDoneProjectTaskDto request)
    {
        var customerId = Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value!);

        var command = new MarkAsDoneCommand(
            id,
            customerId,
            request.Rating);

        var result = await _mediatr.Send(command);

        return result.ToResponse(this);
    }

    [Authorize(Roles = nameof(UserRole.Customer))]
    [HttpPost("{id}/cancel")]
    public async Task<IActionResult> Cancel(
        Guid id)
    {
        var customerId = Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value!);

        var command = new CancelProjectTaskCommand(
            id,
            customerId);

        var result = await _mediatr.Send(command);

        return result.ToResponse(this);
    }

    [Authorize]
    [HttpPost("{id}/assign")]
    public async Task<IActionResult> Assign(
        Guid id,
        [FromBody] AssignProjectTaskDto request)
    {
        var customerId = Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value!);

        var command = new AssignExecutorCommand(
            id,
            request.ExecutorId,
            customerId);

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

    [HttpGet("published")]
    public async Task<IActionResult> GetPublished(
        [FromQuery] PageDto request)
    {
        var currentUserId = Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value!);

        var query = new GetPublishedTasksQuery(
            request.Page,
            request.PageSize,
            currentUserId);

        var result = await _mediatr.Send(query);

        return result.ToResponse(this);
    }

    [Authorize]
    [HttpGet("{id}/responses")]
    public async Task<IActionResult> GetResponses(
        Guid id)
    {
        var query = new GetTaskResponsesQuery(id);

        var result = await _mediatr.Send(query);

        return result.ToResponse(this);
    }

    [Authorize]
    [HttpGet("assigned/{executorId}")]
    public async Task<IActionResult> GetAssigned(
        Guid executorId,
        [FromQuery] PageDto request)
    {
        var query = new GetAssignedTasksQuery(
            executorId,
            request.Page,
            request.PageSize);

        var result = await _mediatr.Send(query);

        return result.ToResponse(this);
    }

    [Authorize]
    [HttpGet("search")]
    public async Task<IActionResult> Search(
        [FromQuery] string query,
        [FromQuery] PageDto request)
    {
        var currentUserId = Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value!);

        var isCustomer = User.IsInRole(nameof(UserRole.Customer));

        var searchQuery = SearchTasksQueryFactory.Create(
            currentUserId,
            isCustomer,
            query,
            request.Page,
            request.PageSize);

        var result = await _mediatr.Send(searchQuery);

        return result.ToResponse(this);
    }
}
