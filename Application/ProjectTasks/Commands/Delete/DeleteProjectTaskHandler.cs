using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos;

namespace Application.ProjectTasks.Commands.DeleteProjectTask;

public class DeleteProjectTaskHandler : IRequestHandler<DeleteProjectTaskCommand, Result>
{
    private readonly IProjectTaskCommandRepository _commandRepository;

    public DeleteProjectTaskHandler(IProjectTaskCommandRepository commandRepository)
    {
        _commandRepository = commandRepository;
    }

    public async Task<Result> Handle(
        DeleteProjectTaskCommand request,
        CancellationToken cancellationToken = default)
    {
        await _commandRepository.DeleteAsync(request.TaskId, cancellationToken);

        return Result.Success();
    }
}