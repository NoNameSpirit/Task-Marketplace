using Domain.Shared;
using MediatR;

namespace Application.ProjectTasks.Commands.RespondToTask;

public record RespondToTaskCommand(
    Guid TaskId,
    Guid ExecutorId) : IRequest<Result>;
