using MediatR;
using Shared.Dtos;

namespace Application.ProjectTasks.Commands.MarkAsDone;

public record MarkAsDoneCommand(
    Guid TaskId) : IRequest<Result>;
