namespace Task_Marketplace.Shared.Dtos.Requests.Attachments.Commands;

public record class UploadAttachmentRequest(
    Guid TaskId);