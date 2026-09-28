using MediatR;
using Shared.Dtos;

namespace Application.ProjectTasks.Commands.DeleteProjectTask;

public record DeleteProjectTaskCommand(
    Guid TaskId) : IRequest<Result>;
