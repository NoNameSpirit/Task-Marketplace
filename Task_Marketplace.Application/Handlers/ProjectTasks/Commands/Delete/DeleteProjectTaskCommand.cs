using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;
using Task_Marketplace.Application.Attributes;
using Task_Marketplace.Application.Interfaces.Cache;

namespace Task_Marketplace.Application.Handlers.ProjectTasks.Commands.Delete;

[LogAction(UserActionType.DeletedTask, nameof(ProjectTask))]
public record DeleteProjectTaskCommand(
    Guid TaskId) : IRequest<Result>, ICacheInvalidation
{
    public string CacheKey { get; } = $"project-task:{TaskId}";
}