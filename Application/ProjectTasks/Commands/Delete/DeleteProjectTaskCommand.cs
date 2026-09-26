using Domain.Shared;
using MediatR;

namespace Application.ProjectTasks.Commands.DeleteProjectTask;

public record DeleteProjectTaskCommand(
    Guid TaskId) : IRequest<Result>;
