using Application.Interfaces;
using Application.ProjectTasks.Commands.AssignExecutor;
using Application.ProjectTasks.Commands.Cancel;
using Application.ProjectTasks.Commands.Create;
using Application.ProjectTasks.Commands.Delete;
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
using Web_Api.Extensions;

namespace Web_Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class ProjectTaskController : ControllerBase
{
    private readonly IMediator _mediatr;
    private readonly ICurrentUser _currentUser;

    public ProjectTaskController(IMediator mediatr, ICurrentUser currentUser)
    {
        _mediatr = mediatr;
        _currentUser = currentUser;
    }

    [HttpPost]
    public async Task<IActionResult> Create(
        [FromBody] CreateProjectTaskDto request,
        CancellationToken cancellationToken)
    {
        var command = new CreateProjectTaskCommand(
            request.Title,
            request.Description,
            request.Price,
            request.StartsAt,
            request.EndsAt);

        var result = await _mediatr.Send(command, cancellationToken);

        if (!result.IsSuccess)
        {
            return result.ToResponse(this);
        }

        return CreatedAtAction(nameof(GetById), new { id = result.Value!.Id }, result.Value);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(
        Guid id,
        CancellationToken cancellationToken)
    {
        var command = new DeleteProjectTaskCommand(id);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [Authorize(Roles = nameof(UserRole.Customer))]
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(
        Guid id,
        [FromBody] UpdateProjectTaskDto request,
        CancellationToken cancellationToken)
    {
        var command = new UpdateProjectTaskCommand(
            id,
            request.Title,
            request.Description,
            request.Price,
            request.StartsAt,
            request.EndsAt);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [Authorize(Roles = nameof(UserRole.Executor))]
    [HttpPost("{id}/respond")]
    public async Task<IActionResult> Respond(
        Guid id,
        CancellationToken cancellationToken)
    {
        var command = new RespondToTaskCommand(id);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [Authorize(Roles = nameof(UserRole.Customer))]
    [HttpPost("{id}/mark-as-done")]
    public async Task<IActionResult> MarkAsDone(
        Guid id,
        [FromBody] MarkAsDoneProjectTaskDto request,
        CancellationToken cancellationToken)
    {
        var command = new MarkAsDoneCommand(
            id,
            request.Rating);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [Authorize(Roles = nameof(UserRole.Customer))]
    [HttpPost("{id}/cancel")]
    public async Task<IActionResult> Cancel(
        Guid id,
        CancellationToken cancellationToken)
    {
        var command = new CancelProjectTaskCommand(id);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [Authorize(Roles = nameof(UserRole.Customer))]
    [HttpPost("{id}/assign")]
    public async Task<IActionResult> Assign(
        Guid id,
        [FromBody] AssignProjectTaskDto request,
        CancellationToken cancellationToken)
    {
        var command = new AssignExecutorCommand(
            id,
            request.ExecutorId);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(
        Guid id,
        CancellationToken cancellationToken)
    {
        var query = new GetProjectTaskByIdQuery(id);

        var result = await _mediatr.Send(query, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpGet("customer/{customerId}")]
    public async Task<IActionResult> GetByCustomer(
        Guid customerId,
        [FromQuery] PageDto request,
        CancellationToken cancellationToken)
    {
        var query = new GetTasksByCustomerQuery(
            customerId,
            request.Page,
            request.PageSize);

        var result = await _mediatr.Send(query, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpGet("published")]
    public async Task<IActionResult> GetPublished(
        [FromQuery] PageDto request,
        CancellationToken cancellationToken)
    {
        var query = new GetPublishedTasksQuery(
            request.Page,
            request.PageSize);

        var result = await _mediatr.Send(query, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpGet("{id}/responses")]
    public async Task<IActionResult> GetResponses(
        Guid id,
        CancellationToken cancellationToken)
    {
        var query = new GetTaskResponsesQuery(id);

        var result = await _mediatr.Send(query, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpGet("assigned/{executorId}")]
    public async Task<IActionResult> GetAssigned(
        Guid executorId,
        [FromQuery] PageDto request,
        CancellationToken cancellationToken)
    {
        var query = new GetAssignedTasksQuery(
            executorId,
            request.Page,
            request.PageSize);

        var result = await _mediatr.Send(query, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpGet("search")]
    public async Task<IActionResult> Search(
        [FromQuery] string query,
        [FromQuery] PageDto request,
        CancellationToken cancellationToken)
    {
        var isCustomer = _currentUser.IsInRole(nameof(UserRole.Customer));

        var searchQuery = SearchTasksQueryFactory.Create(
            _currentUser,
            isCustomer,
            query,
            request.Page,
            request.PageSize);

        var result = await _mediatr.Send(searchQuery, cancellationToken);

        return result.ToResponse(this);
    }
}