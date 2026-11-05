using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;

namespace Task_Marketplace.Application.Handlers.ProjectTasks.Commands.Create;

[LogAction(UserActionType.CreatedTask, nameof(ProjectTask))]
public record class CreateProjectTaskCommand(
    string Title,
    string Description,
    decimal Price,
    DateTimeOffset StartsAt,
    DateTimeOffset EndsAt) : IRequest<Result<ProjectTaskDto>>;