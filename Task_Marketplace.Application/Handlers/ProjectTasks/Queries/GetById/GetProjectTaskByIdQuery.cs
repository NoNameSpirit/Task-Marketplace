using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Task_Marketplace.Application.Interfaces.Cache;

namespace Task_Marketplace.Application.Handlers.ProjectTasks.Queries.GetById;

public record GetProjectTaskByIdQuery(
    Guid TaskId) : IRequest<Result<ProjectTaskDto>>, ICacheQuery
{
    public string CacheKey { get; } = $"project-task:{TaskId}";
    public TimeSpan? Ttl { get; } = TimeSpan.FromMinutes(2);
}