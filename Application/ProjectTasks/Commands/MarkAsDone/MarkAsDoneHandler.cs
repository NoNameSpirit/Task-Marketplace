using Domain.Constants;
using Domain.Shared;
using Infrastructure.Repositories.ProjectTasks.Commands;
using Infrastructure.Repositories.ProjectTasks.Queries;
using MediatR;

namespace Application.ProjectTasks.Commands.MarkAsDone;

public class MarkAsDoneHandler : IRequestHandler<MarkAsDoneCommand, Result>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly IProjectTaskCommandRepository _commandRepository;

    public MarkAsDoneHandler(
        IProjectTaskQueryRepository queryRepository,
        IProjectTaskCommandRepository commandRepository)
    {
        _queryRepository = queryRepository;
        _commandRepository = commandRepository;
    }

    public async Task<Result> Handle(
        MarkAsDoneCommand request,
        CancellationToken cancellationToken = default)
    {
        var task = await _queryRepository.GetByIdAsync(request.TaskId, cancellationToken);

        if (task is null)
        {
            return Result.Failure(ErrorMessages.ProjectTaskNotFound);
        }

        var result = task.MarkAsDone();

        if (!result.IsSuccess)
        {
            return Result.Failure(result.Message);
        }

        await _commandRepository.UpdateAsync(task, cancellationToken);

        return Result.Success();
    }
}