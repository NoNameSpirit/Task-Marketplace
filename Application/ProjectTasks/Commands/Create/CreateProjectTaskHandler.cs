using Application.Mappers;
using Domain.Entities;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.Create;

public class CreateProjectTaskHandler : IRequestHandler<CreateProjectTaskCommand, Result<ProjectTaskDto>>
{
    private readonly IProjectTaskCommandRepository _commandRepository;

    public CreateProjectTaskHandler(
        IProjectTaskCommandRepository commandRepository)
    {
        _commandRepository = commandRepository;
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
            request.CustomerId);

        if (!result.IsSuccess)
        {
            return Result<ProjectTaskDto>.Failure(
                result.Message,
                ErrorType.Validation);
        }

        await _commandRepository.AddAsync(result.Value!);

        return Result<ProjectTaskDto>.Success(ProjectTaskMapper.ToDto(result.Value!));
    }
}
