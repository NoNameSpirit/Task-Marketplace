using Application.Interfaces;
using Domain.Constants;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.Update;

public class UpdateProjectTaskHandler : IRequestHandler<UpdateProjectTaskCommand, Result>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly ICurrentUser _currentUser;

    public UpdateProjectTaskHandler(
        IProjectTaskQueryRepository queryRepository,
        ICurrentUser currentUser)
    {
        _queryRepository = queryRepository;
        _currentUser = currentUser;
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