using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Task_Marketplace.Application.Handlers.ProjectTasks.Queries.GetById;

public record GetProjectTaskByIdQuery(
    Guid TaskId) : IRequest<Result<ProjectTaskDto>>;
