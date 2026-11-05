using Domain.Entities;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Task_Marketplace.Application.Mappers;

public static class ProjectTaskMapper
{
    public static ProjectTaskDto ToDto(
        ProjectTask entity,
        string currency,
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
            entity.ProjectRating,
            entity.CustomerId,
            entity.ExecutorId,
            currency);
    }

    public static PagedResult<ProjectTaskDto> ToPagedDto(
        PagedResult<ProjectTask> paged,
        string currency)
    {
        var dtos = paged.Collection
            .Select(t => ToDto(t, currency))
            .ToList();

        return PagedResult<ProjectTaskDto>.Create(
            dtos,
            paged.Page,
            paged.PageSize,
            paged.TotalCount);
    }
}