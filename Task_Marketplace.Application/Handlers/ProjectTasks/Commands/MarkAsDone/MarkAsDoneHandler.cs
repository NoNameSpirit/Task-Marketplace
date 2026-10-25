using Application.Interfaces;
using Domain.Constants;
using Domain.Interfaces.ProjectTasks;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Task_Marketplace.Application.Handlers.ProjectTasks.Commands.MarkAsDone;

public class MarkAsDoneHandler : IRequestHandler<MarkAsDoneCommand, Result>
{
    private readonly IProjectTaskQueryRepository _taskQueryRepository;
    private readonly IUserQueryRepository _userQueryRepository;
    private readonly ICurrentUser _currentUser;

    public MarkAsDoneHandler(
        IProjectTaskQueryRepository taskQueryRepository,
        IUserQueryRepository userQueryRepository,
        ICurrentUser currentUser)
    {
        _taskQueryRepository = taskQueryRepository;
        _userQueryRepository = userQueryRepository;
        _currentUser = currentUser;
    }

    public async Task<Result> Handle(
        MarkAsDoneCommand request,
        CancellationToken cancellationToken = default)
    {
        var task = await _taskQueryRepository.GetTrackedByIdAsync(
            request.TaskId,
            cancellationToken);

        if (task is null)
        {
            return Result.Failure(
                ErrorMessages.ProjectTaskNotFound,
                ErrorType.NotFound);
        }

        var result = task.MarkAsDone(_currentUser.Id, request.Rating);

        if (!result.IsSuccess)
        {
            return Result.Failure(
                result.Message,
                ErrorType.Validation);
        }

        if (task.ExecutorId.HasValue && request.Rating.HasValue)
        {
            var executor = await _userQueryRepository.GetTrackedByIdAsync(
                task.ExecutorId.Value,
                cancellationToken);

            if (executor is not null)
            {
                var ratings = await _taskQueryRepository.GetRatingsByExecutorAsync(
                    executor.Id,
                    cancellationToken);

                var ratingsWithCurrent = ratings
                    .Append(request.Rating.Value)
                    .ToList();

                executor.RecalculateRating(ratingsWithCurrent);
            }
        }

        return Result.Success();
    }
}