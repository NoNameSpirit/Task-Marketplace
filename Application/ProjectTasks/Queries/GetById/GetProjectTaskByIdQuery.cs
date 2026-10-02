using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.ProjectTasks.Queries.GetProjectTaskById;

public record GetProjectTaskByIdQuery(
    Guid TaskId) : IRequest<Result<ProjectTaskDto>>;
