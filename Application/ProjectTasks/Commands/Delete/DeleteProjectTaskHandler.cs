using Domain.Interfaces;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;

namespace Application.ProjectTasks.Commands.DeleteProjectTask;

public class DeleteProjectTaskHandler : IRequestHandler<DeleteProjectTaskCommand, Result>
{
    private readonly IProjectTaskCommandRepository _commandRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteProjectTaskHandler(
        IProjectTaskCommandRepository commandRepository,
        IUnitOfWork unitOfWork)
    {
        _commandRepository = commandRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(
        DeleteProjectTaskCommand request,
        CancellationToken cancellationToken = default)
    {
        await _commandRepository.DeleteAsync(request.TaskId, cancellationToken);

        await _unitOfWork.SaveChangesAsync();

        return Result.Success();
    }
}