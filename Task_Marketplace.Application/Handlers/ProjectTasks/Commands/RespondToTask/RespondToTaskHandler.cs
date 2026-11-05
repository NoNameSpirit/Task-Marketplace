using Application.Interfaces;
using Domain.Constants;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Task_Marketplace.Application.Handlers.ProjectTasks.Commands.RespondToTask;

public class RespondToTaskHandler : IRequestHandler<RespondToTaskCommand, Result>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly ICurrentUser _currentUser;

    public RespondToTaskHandler(
        IProjectTaskQueryRepository queryRepository,
        ICurrentUser currentUser)
    {
        _queryRepository = queryRepository;
        _currentUser = currentUser;
    }

    public async Task<Result> Handle(
        RespondToTaskCommand request,
        CancellationToken cancellationToken = default)
    {
        var task = await _queryRepository.GetTrackedByIdAsync(request.TaskId, cancellationToken);

        if (task is null)
        {
            return Result.Failure(
                ErrorMessages.ProjectTaskNotFound,
                ErrorType.NotFound);
        }

        var result = task.RespondToTask(_currentUser.Id);

        if (!result.IsSuccess)
        {
            return Result.Failure(
                result.Message,
                ErrorType.Validation);
        }

        return Result.Success();
    }
}