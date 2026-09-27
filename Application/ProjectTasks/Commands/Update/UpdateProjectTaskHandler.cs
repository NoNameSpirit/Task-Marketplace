using Domain.Constants;
using Domain.Interfaces.ProjectTasks;
using Domain.Shared;
using MediatR;

namespace Application.ProjectTasks.Commands.Update;

public class UpdateProjectTaskHandler : IRequestHandler<UpdateProjectTaskCommand, Result>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly IProjectTaskCommandRepository _commandRepository;

    public UpdateProjectTaskHandler(
        IProjectTaskQueryRepository queryRepository,
        IProjectTaskCommandRepository commandRepository)
    {
        _queryRepository = queryRepository;
        _commandRepository = commandRepository;
    }

    public async Task<Result> Handle(
        UpdateProjectTaskCommand request,
        CancellationToken cancellationToken = default)
    {
        var task = await _queryRepository.GetByIdAsync(request.TaskId, cancellationToken);

        if (task is null)
        {
            return Result.Failure(ErrorMessages.ProjectTaskNotFound);
        }

        var result = task.Update(
            request.Title,
            request.Description,
            request.Price,
            request.StartsAt,
            request.EndsAt,
            request.CustomerId);

        if (!result.IsSuccess)
        {
            return Result.Failure(result.Message);
        }

        await _commandRepository.UpdateAsync(task, cancellationToken);

        return Result.Success();
    }
}
