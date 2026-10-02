using Domain.Entities;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.Mappers;

public static class ProjectTaskMapper
{
    public static ProjectTaskDto ToDto(
        ProjectTask entity,
        bool isRespondedByCurrentUser = false)
    {
        return new ProjectTaskDto(
            entity.Id,
            entity.Title,
            entity.Description,
            entity.Price,
            entity.Status,
            entity.StartsAt,
            entity.EndsAt,
            isRespondedByCurrentUser,
            entity.ProjectRating);
    }

    public static PagedResult<ProjectTaskDto> ToPagedDto(PagedResult<ProjectTask> paged)
    {
        var dtos = paged.Collection
            .Select(t => ToDto(t))
            .ToList();

        var pagedResult = PagedResult<ProjectTaskDto>.Create(
            dtos,
            paged.Page,
            paged.PageSize,
            paged.TotalCount);

        return pagedResult;
    }

    public static List<TaskResponseDto> ToResponseDtos(ProjectTask entity)
    {
        if (entity.Responses is null || !entity.Responses.Any())
            return new List<TaskResponseDto>();

        return entity.Responses
            .Select(r => new TaskResponseDto
            {
                ExecutorId = r.ExecutorId,
                ExecutorName = $"Executor {r.ExecutorId}",
                RespondedAt = r.RespondedAt
            })
            .ToList();
    }
}