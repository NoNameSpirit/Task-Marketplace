using MediatR;
using Shared.Dtos.Responses;

namespace Application.ProjectTasks.Commands.Cancel;

public record CancelProjectTaskCommand(
    Guid TaskId,
    Guid CustomerId) : IRequest<Result>;