using Domain.Constants;
using Domain.Interfaces;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.Update;

public class UpdateProjectTaskHandler : IRequestHandler<UpdateProjectTaskCommand, Result>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly IProjectTaskCommandRepository _commandRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateProjectTaskHandler(
        IProjectTaskQueryRepository queryRepository,
        IProjectTaskCommandRepository commandRepository,
        IUnitOfWork unitOfWork)
    {
        _queryRepository = queryRepository;
        _commandRepository = commandRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(
        UpdateProjectTaskCommand request,
        CancellationToken cancellationToken = default)
    {
        var task = await _queryRepository.GetTrackedByIdAsync(request.TaskId, cancellationToken);

        if (task is null)
        {
            return Result.Failure(
                ErrorMessages.ProjectTaskNotFound,
                ErrorType.NotFound);
        }

        var result = task.Update(
            request.Title,
            request.Description,
            request.Price,
            request.StartsAt,
            request.EndsAt,
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
