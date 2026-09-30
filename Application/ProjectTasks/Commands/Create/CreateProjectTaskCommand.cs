using MediatR;
using Shared.Dtos;
using Shared.Dtos.ProjectTasks;

namespace Application.ProjectTasks.Commands.Create;

public record class CreateProjectTaskCommand(
    string Title,
    string Description,
    decimal Price,
    DateTimeOffset StartsAt,
    DateTimeOffset EndsAt,
    Guid CustomerId) : IRequest<Result<ProjectTaskDto>>;
