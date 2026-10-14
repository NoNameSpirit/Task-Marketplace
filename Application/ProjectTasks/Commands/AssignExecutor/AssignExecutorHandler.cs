using Domain.Constants;
using Domain.Interfaces;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.AssignExecutor;

public class AssignExecutorHandler : IRequestHandler<AssignExecutorCommand, Result>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly IProjectTaskCommandRepository _commandRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AssignExecutorHandler(
        IProjectTaskQueryRepository queryRepository,
        IProjectTaskCommandRepository commandRepository,
        IUnitOfWork unitOfWork)
    {
        _queryRepository = queryRepository;
        _commandRepository = commandRepository;
        _unitOfWork = unitOfWork;
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
            request.CurrentUserId);

        if (!result.IsSuccess)
        {
            return Result.Failure(
                result.Message,
                ErrorType.Validation);
        }

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}
