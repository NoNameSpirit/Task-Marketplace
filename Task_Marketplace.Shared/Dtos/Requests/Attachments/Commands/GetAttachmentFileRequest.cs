namespace Task_Marketplace.Shared.Dtos.Requests.Attachments.Queries;

public record class GetAttachmentFileRequest(
    Guid TaskId,
    Guid AttachmentId);