using Domain.Entities;
using MediatR;
using Shared.Dtos;

namespace Application.ProjectTasks.Commands.Create;

public record class CreateProjectTaskCommand(
    string Title,
    string Description,
    decimal Price,
    DateTimeOffset StartsAt,
    DateTimeOffset EndsAt,
    Guid CustomerId) : IRequest<Result<ProjectTask>>;
