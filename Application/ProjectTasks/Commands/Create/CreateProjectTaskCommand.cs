using Domain.Entities;
using Domain.Shared;
using MediatR;

namespace Application.ProjectTasks.Commands.Create;

public record class CreateProjectTaskCommand(
    string Title,
    string Description,
    decimal Price,
    DateTimeOffset StartsAt,
    DateTimeOffset EndsAt,
    Guid CustomerId) : IRequest<Result<ProjectTask>>;
