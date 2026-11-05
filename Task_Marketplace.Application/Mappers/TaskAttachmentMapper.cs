using Domain.Entities;
using Shared.Dtos.Responses.ProjectTasks;

namespace Task_Marketplace.Application.Mappers;

public static class TaskAttachmentMapper
{
    public static TaskAttachmentDto ToDto(TaskAttachment entity)
    {
        return new TaskAttachmentDto(
            entity.Id,
            entity.TaskId,
            entity.UploadedByUserId,
            entity.OriginalFileName,
            entity.ContentType,
            entity.SizeBytes,
            entity.UploadedAt);
    }

    public static List<TaskAttachmentDto> ToDtoList(
        IReadOnlyCollection<TaskAttachment> entities)
    {
        return entities.Select(ToDto).ToList();
    }
}