namespace Shared.Dtos.Responses.ProjectTasks;

public class TaskAttachmentDto
{
    public Guid Id { get; set; }
    public Guid TaskId { get; set; }
    public Guid UploadedByUserId { get; set; }
    public string OriginalFileName { get; set; } = string.Empty;
    public string ContentType { get; set; } = string.Empty;
    public long SizeBytes { get; set; }
    public DateTimeOffset UploadedAt { get; set; }

    public TaskAttachmentDto() { }

    public TaskAttachmentDto(
        Guid id,
        Guid taskId,
        Guid uploadedByUserId,
        string originalFileName,
        string contentType,
        long sizeBytes,
        DateTimeOffset uploadedAt)
    {
        Id = id;
        TaskId = taskId;
        UploadedByUserId = uploadedByUserId;
        OriginalFileName = originalFileName;
        ContentType = contentType;
        SizeBytes = sizeBytes;
        UploadedAt = uploadedAt;
    }
}