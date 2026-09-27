using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.ProjectTasks;
using Domain.Shared;
using MediatR;

namespace Application.ProjectTasks.Queries.GetProjectTaskById;

public class GetProjectTaskByIdHandler : IRequestHandler<GetProjectTaskByIdQuery, Result<ProjectTask>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;

    public GetProjectTaskByIdHandler(IProjectTaskQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result<ProjectTask>> Handle(
        GetProjectTaskByIdQuery request,
        CancellationToken cancellationToken = default)
    {
        var projectTask = await _queryRepository.GetByIdAsync(request.TaskId, cancellationToken);

        if (projectTask is null)
        {
            Result<ProjectTask>.Failure(ErrorMessages.ProjectTaskNotFound);
        }

        return Result<ProjectTask>.Success(projectTask!);
    }
}
