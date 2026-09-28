using Domain.Constants;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos;

namespace Application.ProjectTasks.Commands.AssignExecutor;

public class AssignExecutorHandler : IRequestHandler<AssignExecutorCommand, Result>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly IProjectTaskCommandRepository _commandRepository;

    public AssignExecutorHandler(
        IProjectTaskQueryRepository queryRepository,
        IProjectTaskCommandRepository commandRepository)
    {
        _queryRepository = queryRepository;
        _commandRepository = commandRepository;
    }

    public async Task<Result> Handle(
        AssignExecutorCommand request,
        CancellationToken cancellationToken = default)
    {
        var task = await _queryRepository.GetByIdAsync(request.TaskId, cancellationToken);

        if (task is null)
        {
            return Result.Failure(ErrorMessages.ProjectTaskNotFound);
        }

        var result = task.AssignExecutor(request.ExecutorId, request.CustomerId);

        if (!result.IsSuccess)
        {
            return Result.Failure(result.Message);
        }

        await _commandRepository.UpdateAsync(task, cancellationToken);

        return Result.Success();
    }
}
