using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;
using Task_Marketplace.Application.Attributes;

namespace Task_Marketplace.Application.Handlers.ProjectTasks.Commands.RespondToTask;

[LogAction(UserActionType.RespondedToTask, nameof(ProjectTask))]
public record RespondToTaskCommand(
    Guid TaskId) : IRequest<Result>;