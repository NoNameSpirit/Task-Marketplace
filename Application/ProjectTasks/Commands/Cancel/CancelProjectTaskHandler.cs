using Domain.Constants;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.Cancel;

public class CancelProjectTaskHandler : IRequestHandler<CancelProjectTaskCommand, Result>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly IProjectTaskCommandRepository _commandRepository;

    public CancelProjectTaskHandler(
        IProjectTaskQueryRepository queryRepository,
        IProjectTaskCommandRepository commandRepository)
    {
        _queryRepository = queryRepository;
        _commandRepository = commandRepository;
    }

    public async Task<Result> Handle(
        CancelProjectTaskCommand request,
        CancellationToken cancellationToken = default)
    {
        var task = await _queryRepository.GetTrackedByIdAsync(
            request.TaskId,
            cancellationToken);

        if (task is null)
        {
            return Result.Failure(
                ErrorMessages.ProjectTaskNotFound,
                ErrorType.NotFound);
        }

        var result = task.Cancel(request.CustomerId);

        if (!result.IsSuccess)
        {
            return Result.Failure(
                result.Message,
                ErrorType.Validation);
        }

        await _commandRepository.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}