using Domain.Configuration;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;
using Task_Marketplace.Application.Interfaces;
using Task_Marketplace.Application.Interfaces.Repositories.ProjectTasks;
using Task_Marketplace.Application.Mappers;

namespace Task_Marketplace.Application.Handlers.ProjectTasks.Commands.Create;

public class CreateProjectTaskHandler : IRequestHandler<CreateProjectTaskCommand, Result<ProjectTaskDto>>
{
    private readonly IProjectTaskCommandRepository _commandRepository;
    private readonly ICurrentUser _currentUser;
    private readonly string _currency;

    public CreateProjectTaskHandler(
        IProjectTaskCommandRepository commandRepository,
        AppConfiguration appConfig,
        ICurrentUser currentUser)
    {
        _commandRepository = commandRepository;
        _currency = appConfig.Currency;
        _currentUser = currentUser;
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
            _currentUser.Id);

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
                _currency));
    }
}