using Domain.Constants;
using Shared.Dtos.Responses;

namespace Domain.Entities;

public class TaskAttachment : Entity
{
    public Guid TaskId { get; private set; }
    public ProjectTask Task { get; private set; } = null!;

    public Guid UploadedByUserId { get; private set; }
    public User UploadedByUser { get; private set; } = null!;

    public string OriginalFileName { get; private set; } = string.Empty;
    public string StoredFileName { get; private set; } = string.Empty;
    public string ContentType { get; private set; } = string.Empty;
    public long SizeBytes { get; private set; }
    public DateTimeOffset UploadedAt { get; private set; }

    private TaskAttachment() { }

    public static Result<TaskAttachment> Create(
        Guid taskId,
        Guid uploadedByUserId,
        string originalFileName,
        string storedFileName,
        string contentType,
        long sizeBytes)
    {
        var result = Validate(
            taskId,
            uploadedByUserId,
            originalFileName,
            storedFileName,
            sizeBytes);
        if (!result.IsSuccess)
        {
            return Result<TaskAttachment>.Failure(result.Message);
        }

        var attachment = new TaskAttachment()
        {
            Id = Guid.NewGuid(),
            TaskId = taskId,
            UploadedByUserId = uploadedByUserId,
            OriginalFileName = originalFileName,
            StoredFileName = storedFileName,
            ContentType = string.IsNullOrWhiteSpace(contentType)
                ? AttachmentConstants.DefaultContentType
                : contentType,
            SizeBytes = sizeBytes,
            UploadedAt = DateTimeOffset.UtcNow
        };

        return Result<TaskAttachment>.Success(attachment);
    }

    private static Result Validate(
        Guid taskId,
        Guid uploadedByUserId,
        string originalFileName,
        string storedFileName,
        long sizeBytes)
    {
        if (taskId == Guid.Empty)
        {
            return Result.Failure(ErrorMessages.TaskIdCannotBeEmpty);
        }

        if (uploadedByUserId == Guid.Empty)
        {
            return Result.Failure(ErrorMessages.UploadedByUserIdCannotBeEmpty);
        }

        if (string.IsNullOrWhiteSpace(originalFileName))
        {
            return Result.Failure(ErrorMessages.OriginalFileNameCannotBeEmpty);
        }

        if (string.IsNullOrWhiteSpace(storedFileName))
        {
            return Result.Failure(ErrorMessages.StoredFileNameCannotBeEmpty);
        }

        if (sizeBytes <= AttachmentConstants.MinSizeBytes)
        {
            return Result.Failure(ErrorMessages.FileSizeMustBePositive);
        }

        if (sizeBytes > AttachmentConstants.MaxSizeBytes)
        {
            return Result.Failure(string.Format(
                ErrorMessages.FileSizeExceedsLimit,
                AttachmentConstants.MaxSizeBytes / (1024 * 1024)));
        }

        return Result.Success();
    }
}