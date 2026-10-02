using Domain.Constants;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;

namespace Application.ProjectTasks.Queries.GetResponses;

public class GetTaskResponsesHandler : IRequestHandler<GetTaskResponsesQuery, Result<List<TaskResponseDto>>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;

    public GetTaskResponsesHandler(IProjectTaskQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
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

        var responses = await _queryRepository.GetResponsesByTaskIdAsync(request.TaskId, cancellationToken);

        return Result<List<TaskResponseDto>>.Success(responses);
    }
}