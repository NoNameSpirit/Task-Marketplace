using Domain.Entities;
using Domain.Interfaces.ProjectTasks;
using Domain.Shared;
using MediatR;

namespace Application.ProjectTasks.Commands.Create;

public class CreateProjectTaskHandler : IRequestHandler<CreateProjectTaskCommand, Result<ProjectTask>>
{
    private readonly IProjectTaskCommandRepository _commandRepository;

    public CreateProjectTaskHandler(IProjectTaskCommandRepository commandRepository)
    {
        _commandRepository = commandRepository;
    }

    public async Task<Result<ProjectTask>> Handle(
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
            return Result<ProjectTask>.Failure(result.Message);
        }

        await _commandRepository.AddAsync(result.Value!);

        return Result<ProjectTask>.Success(result.Value!);
    }
}
