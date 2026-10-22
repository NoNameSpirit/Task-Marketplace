using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.Delete;

[LogAction(UserActionType.DeletedTask, nameof(ProjectTask))]
public record DeleteProjectTaskCommand(
    Guid TaskId) : IRequest<Result>;