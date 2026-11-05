using Application.Interfaces;
using Domain.Constants;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;

namespace Task_Marketplace.Application.Handlers.ProjectTasks.Queries.GetResponses;

public class GetTaskResponsesHandler : IRequestHandler<GetTaskResponsesQuery, Result<List<TaskResponseDto>>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly ICurrentUser _currentUser;

    public GetTaskResponsesHandler(
        IProjectTaskQueryRepository queryRepository,
        ICurrentUser currentUser)
    {
        _queryRepository = queryRepository;
        _currentUser = currentUser;
    }

    public async Task<Result<List<TaskResponseDto>>> Handle(
        GetTaskResponsesQuery request,
        CancellationToken cancellationToken = default)
    {
        var task = await _queryRepository.GetByIdAsync(request.TaskId, cancellationToken);

        if (task is null)
        {
            return Result<List<TaskResponseDto>>.Failure(
                ErrorMessages.ProjectTaskNotFound,
                ErrorType.NotFound);
        }

        if (task.CustomerId != _currentUser.Id)
        {
            return Result<List<TaskResponseDto>>.Failure(
                ErrorMessages.Forbidden,
                ErrorType.Forbidden);
        }

        var responses = await _queryRepository.GetResponsesByTaskIdAsync(request.TaskId, cancellationToken);

        return Result<List<TaskResponseDto>>.Success(responses);
    }
}