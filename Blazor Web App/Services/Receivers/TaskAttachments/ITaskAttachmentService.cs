using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Blazor_Web_App.Services.Receivers.TaskAttachments;

public interface ITaskAttachmentService
{
    Task<Result<List<TaskAttachmentDto>>> GetTaskAttachmentsAsync(Guid taskId, CancellationToken cancellationToken = default);

    Task<Result<TaskAttachmentDto>> UploadAttachmentAsync(Guid taskId, Stream content, string fileName, string contentType, CancellationToken cancellationToken = default);

    Task<Result> DeleteAttachmentAsync(Guid taskId, Guid attachmentId, CancellationToken cancellationToken = default);

    Task<Result<AttachmentFileResult>> DownloadAttachmentAsync(Guid taskId, Guid attachmentId, CancellationToken cancellationToken = default);
}