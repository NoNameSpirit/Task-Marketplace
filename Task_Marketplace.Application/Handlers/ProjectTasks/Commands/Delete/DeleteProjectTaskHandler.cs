using Application.Interfaces;
using Domain.Constants;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Task_Marketplace.Application.Handlers.ProjectTasks.Commands.Delete;

public class DeleteProjectTaskHandler : IRequestHandler<DeleteProjectTaskCommand, Result>
{
    private readonly IProjectTaskQueryRepository _taskQueryRepository;
    private readonly ICurrentUser _currentUser;

    public DeleteProjectTaskHandler(
        IProjectTaskQueryRepository taskQueryRepository,
        ICurrentUser currentUser)
    {
        _taskQueryRepository = taskQueryRepository;
        _currentUser = currentUser;
    }

    public async Task<Result> Handle(
        DeleteProjectTaskCommand request,
        CancellationToken cancellationToken = default)
    {
        var task = await _taskQueryRepository.GetTrackedByIdAsync(request.TaskId, cancellationToken);

        if (task is null)
        {
            return Result.Failure(ErrorMessages.ProjectTaskNotFound, ErrorType.NotFound);
        }

        if (task.CustomerId != _currentUser.Id)
        {
            return Result.Failure(ErrorMessages.Forbidden, ErrorType.Forbidden);
        }

        task.Delete();

        return Result.Success();
    }
}