using Domain.Entities;
using Shared.Dtos;
using Shared.Dtos.ProjectTasks;

namespace Application.Mappers;

public static class ProjectTaskMapper
{
    public static ProjectTaskDto ToDto(ProjectTask entity)
    {
        return new ProjectTaskDto(
            entity.Id,
            entity.Title,
            entity.Description,
            entity.Price,
            entity.Status,
            entity.StartsAt,
            entity.EndsAt);
    }

    public static PagedResult<ProjectTaskDto> ToPagedDto(PagedResult<ProjectTask> paged)
    {
        var dtos = paged.Collection
            .Select(ToDto)
            .ToList();

        var pagedResult = PagedResult<ProjectTaskDto>.Create(
            dtos,
            paged.Page,
            paged.PageSize,
            paged.TotalCount);

        return pagedResult;
    }
}