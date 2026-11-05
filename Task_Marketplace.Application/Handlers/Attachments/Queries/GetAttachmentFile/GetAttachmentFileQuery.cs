using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Task_Marketplace.Application.Handlers.Attachments.Queries.GetAttachmentFile;

public record GetAttachmentFileQuery(
    Guid AttachmentId) : IRequest<Result<AttachmentFileResult>>;
