using MediatR;
using Shared.Dtos;

namespace Application.ProjectTasks.Commands.Update;

public record class UpdateProjectTaskCommand(
    Guid TaskId,
    string Title,
    string Description,
    decimal Price,
    DateTimeOffset StartsAt,
    DateTimeOffset EndsAt,
    Guid CustomerId) : IRequest<Result>;
