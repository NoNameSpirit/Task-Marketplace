using MediatR;
using Shared.Dtos.Responses;

namespace Application.ProjectTasks.Commands.MarkAsDone;

public record MarkAsDoneCommand(
    Guid TaskId,
    Guid CustomerId,
    decimal? Rating) : IRequest<Result>;