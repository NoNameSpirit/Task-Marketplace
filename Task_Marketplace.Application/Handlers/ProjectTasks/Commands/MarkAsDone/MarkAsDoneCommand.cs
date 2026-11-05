using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;
using Task_Marketplace.Application.Abstraction.Cache;

namespace Task_Marketplace.Application.Handlers.ProjectTasks.Commands.MarkAsDone;

[LogAction(UserActionType.MarkedTaskDone, nameof(ProjectTask))]
public record MarkAsDoneCommand(
    Guid TaskId,
    decimal? Rating) : IRequest<Result>, ICacheInvalidation
{
    public string CacheKey { get; } = $"project-task:{TaskId}";
}