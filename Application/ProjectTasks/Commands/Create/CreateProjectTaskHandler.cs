using Domain.Entities;
using Domain.Shared;
using Infrastructure.Repositories.ProjectTasks.Commands;
using MediatR;

namespace Application.ProjectTasks.Commands.Create;

public class CreateProjectTaskHandler : IRequestHandler<CreateProjectTaskCommand, Result>
{
    private readonly IProjectTaskCommandRepository _commandRepository;

    public CreateProjectTaskHandler(IProjectTaskCommandRepository commandRepository)
    {
        _commandRepository = commandRepository;
    }

    public async Task<Result> Handle(
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
            return Result.Failure(result.Message);
        }

        await _commandRepository.AddAsync(result.Value!);

        return Result.Success();
    }
}
