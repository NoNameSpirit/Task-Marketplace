using Domain.Constants;
using Domain.Interfaces;
using Domain.Interfaces.ProjectTasks;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.MarkAsDone;

public class MarkAsDoneHandler : IRequestHandler<MarkAsDoneCommand, Result>
{
    private readonly IProjectTaskQueryRepository _taskQueryRepository;
    private readonly IProjectTaskCommandRepository _taskCommandRepository;
    private readonly IUserQueryRepository _userQueryRepository;
    private readonly IUserCommandRepository _userCommandRepository;
    private readonly IUnitOfWork _unitOfWork;

    public MarkAsDoneHandler(
        IProjectTaskQueryRepository taskQueryRepository,
        IProjectTaskCommandRepository taskCommandRepository,
        IUserQueryRepository userQueryRepository,
        IUserCommandRepository userCommandRepository,
        IUnitOfWork unitOfWork)
    {
        _taskQueryRepository = taskQueryRepository;
        _taskCommandRepository = taskCommandRepository;
        _userQueryRepository = userQueryRepository;
        _userCommandRepository = userCommandRepository;
        _unitOfWork = unitOfWork;
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

        var result = task.MarkAsDone(request.CurrentUserId, request.Rating);

        if (!result.IsSuccess)
        {
            return Result.Failure(
                result.Message,
                ErrorType.Validation);
        }

        await _unitOfWork.SaveChangesAsync(cancellationToken);

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

                executor.RecalculateRating(ratings);
            }
        }

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}