using Application.Mappers;
using Domain.Constants;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos;
using Shared.Dtos.ProjectTasks;

namespace Application.ProjectTasks.Queries.GetProjectTaskById;

public class GetProjectTaskByIdHandler : IRequestHandler<GetProjectTaskByIdQuery, Result<ProjectTaskDto>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;

    public GetProjectTaskByIdHandler(IProjectTaskQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result<ProjectTaskDto>> Handle(
        GetProjectTaskByIdQuery request,
        CancellationToken cancellationToken = default)
    {
        var projectTask = await _queryRepository.GetByIdAsync(request.TaskId, cancellationToken);

        if (projectTask is null)
        {
            Result<ProjectTaskDto>.Failure(ErrorMessages.ProjectTaskNotFound);
        }

        return Result<ProjectTaskDto>.Success(ProjectTaskMapper.ToDto(projectTask!));
    }
}
