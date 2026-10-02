using MediatR;
using Shared.Dtos.Responses;

namespace Application.ProjectTasks.Commands.RespondToTask;

public record RespondToTaskCommand(
    Guid TaskId,
    Guid ExecutorId) : IRequest<Result>;
