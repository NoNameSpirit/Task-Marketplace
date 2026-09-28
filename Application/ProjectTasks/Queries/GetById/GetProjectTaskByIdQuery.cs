using MediatR;
using Shared.Dtos;
using Shared.Dtos.ProjectTasks;

namespace Application.ProjectTasks.Queries.GetProjectTaskById;

public record GetProjectTaskByIdQuery(
    Guid TaskId) : IRequest<Result<ProjectTaskDto>>;
