using Domain.Shared;
using MediatR;

namespace Application.ProjectTasks.Commands.MarkAsDone;

public record MarkAsDoneCommand(
    Guid TaskId) : IRequest<Result>;
