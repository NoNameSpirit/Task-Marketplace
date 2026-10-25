using Application.Mappers;
using Domain.Config;
using Domain.Constants;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Microsoft.Extensions.Options;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;

namespace Task_Marketplace.Application.Handlers.ProjectTasks.Queries.GetById;

public class GetProjectTaskByIdHandler : IRequestHandler<GetProjectTaskByIdQuery, Result<ProjectTaskDto>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly AppConfig _appConfig;

    public GetProjectTaskByIdHandler(
        IProjectTaskQueryRepository queryRepository,
        IOptions<AppConfig> appConfig)
    {
        _queryRepository = queryRepository;
        _appConfig = appConfig.Value;
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
