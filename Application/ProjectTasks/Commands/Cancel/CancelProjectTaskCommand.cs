using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.Cancel;

[LogAction(UserActionType.CancelledTask, nameof(ProjectTask))]
public record CancelProjectTaskCommand(
    Guid TaskId) : IRequest<Result>;