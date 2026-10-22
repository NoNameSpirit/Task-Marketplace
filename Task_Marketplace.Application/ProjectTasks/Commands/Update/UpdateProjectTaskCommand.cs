using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.Update;

[LogAction(UserActionType.UpdatedTask, nameof(ProjectTask))]
public record class UpdateProjectTaskCommand(
    Guid TaskId,
    string Title,
    string Description,
    decimal Price,
    DateTimeOffset StartsAt,
    DateTimeOffset EndsAt) : IRequest<Result>;