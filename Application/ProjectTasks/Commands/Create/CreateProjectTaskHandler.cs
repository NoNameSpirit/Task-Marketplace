using Application.Mappers;
using Domain.Config;
using Domain.Entities;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Microsoft.Extensions.Options;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.Create;

public class CreateProjectTaskHandler : IRequestHandler<CreateProjectTaskCommand, Result<ProjectTaskDto>>
{
    private readonly IProjectTaskCommandRepository _commandRepository;
    private readonly AppConfig _appConfig;

    public CreateProjectTaskHandler(
        IProjectTaskCommandRepository commandRepository,
        IOptions<AppConfig> appConfig)
    {
        _commandRepository = commandRepository;
        _appConfig = appConfig.Value;
    }

    public async Task<Result<ProjectTaskDto>> Handle(
        CreateProjectTaskCommand request,
        CancellationToken cancellationToken)
    {
        var result = ProjectTask.Create(
            request.Title,
            request.Description,
            request.Price,
            request.StartsAt,
            request.EndsAt,
            request.CurrentUserId);

        if (!result.IsSuccess)
        {
            return Result<ProjectTaskDto>.Failure(
                result.Message,
                ErrorType.Validation);
        }

        await _commandRepository.AddAsync(result.Value!);

        return Result<ProjectTaskDto>.Success(
            ProjectTaskMapper.ToDto(
                result.Value!,
                _appConfig.Currency));
    }
}
