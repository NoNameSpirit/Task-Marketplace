namespace Task_Marketplace.Shared.Dtos.Requests.Attachments.Commands;

public record class DeleteAttachmentRequest(
    Guid TaskId,
    Guid AttachmentId);