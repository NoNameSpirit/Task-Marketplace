using Application.Interfaces;
using Domain.Constants;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.AssignExecutor;

public class AssignExecutorHandler : IRequestHandler<AssignExecutorCommand, Result>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly ICurrentUser _currentUser;

    public AssignExecutorHandler(
        IProjectTaskQueryRepository queryRepository,
        ICurrentUser currentUser)
    {
        _queryRepository = queryRepository;
        _currentUser = currentUser;
    }

    public async Task<Result> Handle(
        AssignExecutorCommand request,
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

        var result = task.AssignExecutor(
            request.ExecutorId,
            _currentUser.Id);

        if (!result.IsSuccess)
        {
            return Result.Failure(
                result.Message,
                ErrorType.Validation);
        }

        return Result.Success();
    }
}