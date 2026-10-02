using MediatR;
using Shared.Dtos.Responses;

namespace Application.ProjectTasks.Commands.Update;

public record class UpdateProjectTaskCommand(
    Guid TaskId,
    string Title,
    string Description,
    decimal Price,
    DateTimeOffset StartsAt,
    DateTimeOffset EndsAt,
    Guid CustomerId) : IRequest<Result>;
