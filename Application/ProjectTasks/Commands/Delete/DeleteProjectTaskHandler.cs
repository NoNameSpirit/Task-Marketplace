using Domain.Constants;
using Domain.Interfaces;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.DeleteProjectTask;

public class DeleteProjectTaskHandler : IRequestHandler<DeleteProjectTaskCommand, Result>
{
    private readonly IProjectTaskQueryRepository _taskQueryRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteProjectTaskHandler(
        IProjectTaskQueryRepository taskQueryRepository,
        IUnitOfWork unitOfWork)
    {
        _taskQueryRepository = taskQueryRepository;
        _unitOfWork = unitOfWork;
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

        if (task.CustomerId != request.CurrentUserId)
        {
            return Result.Failure(ErrorMessages.Forbidden, ErrorType.Forbidden);
        }
        task.Delete();

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}