using MediatR;
using Shared.Dtos.Responses;

namespace Application.ProjectTasks.Commands.AssignExecutor;

public record AssignExecutorCommand(
    Guid TaskId,
    Guid ExecutorId,
    Guid CustomerId) : IRequest<Result>;
