using Domain.Entities;
using Domain.Shared;
using MediatR;

namespace Application.ProjectTasks.Queries.GetProjectTaskById;

public record GetProjectTaskByIdQuery(
    Guid TaskId) : IRequest<Result<ProjectTask>>;
