using Domain.Configuration;
using Domain.Constants;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;
using Task_Marketplace.Application.Interfaces.Repositories.ProjectTasks;
using Task_Marketplace.Application.Mappers;

namespace Task_Marketplace.Application.Handlers.ProjectTasks.Queries.GetById;

public class GetProjectTaskByIdHandler : IRequestHandler<GetProjectTaskByIdQuery, Result<ProjectTaskDto>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly AppConfiguration _appConfig;

    public GetProjectTaskByIdHandler(
        IProjectTaskQueryRepository queryRepository,
        AppConfiguration appConfig)
    {
        _queryRepository = queryRepository;
        _appConfig = appConfig;
    }

    public async Task<Result<ProjectTaskDto>> Handle(
        GetProjectTaskByIdQuery request,
        CancellationToken cancellationToken = default)
    {
        var projectTask = await _queryRepository.GetByIdAsync(request.TaskId, cancellationToken);

        if (projectTask is null)
        {
            return Result<ProjectTaskDto>.Failure(
                ErrorMessages.ProjectTaskNotFound,
                ErrorType.NotFound);
        }

        return Result<ProjectTaskDto>.Success(
            ProjectTaskMapper.ToDto(
                projectTask!,
                _appConfig.Currency));
    }
}
