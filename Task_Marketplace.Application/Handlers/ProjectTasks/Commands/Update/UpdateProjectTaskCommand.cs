using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;
using Task_Marketplace.Application.Abstraction.Cache;

namespace Task_Marketplace.Application.Handlers.ProjectTasks.Commands.Update;

[LogAction(UserActionType.UpdatedTask, nameof(ProjectTask))]
public record class UpdateProjectTaskCommand(
    Guid TaskId,
    string Title,
    string Description,
    decimal Price,
    DateTimeOffset StartsAt,
    DateTimeOffset EndsAt) : IRequest<Result>, ICacheInvalidation
{
    public string CacheKey { get; } = $"project-task:{TaskId}";
}