using Domain.Shared;
using MediatR;

namespace Application.ProjectTasks.Commands.AssignExecutor;

public record AssignExecutorCommand(
    Guid TaskId,
    Guid ExecutorId,
    Guid CustomerId) : IRequest<Result>;
