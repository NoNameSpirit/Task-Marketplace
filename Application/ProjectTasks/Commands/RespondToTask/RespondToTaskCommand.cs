using MediatR;
using Shared.Dtos;

namespace Application.ProjectTasks.Commands.RespondToTask;

public record RespondToTaskCommand(
    Guid TaskId,
    Guid ExecutorId) : IRequest<Result>;
