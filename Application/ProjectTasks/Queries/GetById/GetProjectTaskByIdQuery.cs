using Domain.Entities;
using MediatR;

namespace Application.ProjectTasks.Queries.GetProjectTaskById;

public record GetProjectTaskByIdQuery(
    Guid TaskId) : IRequest<ProjectTask?>;
