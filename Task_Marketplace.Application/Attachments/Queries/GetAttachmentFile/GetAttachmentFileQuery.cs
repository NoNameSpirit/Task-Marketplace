using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.Attachments.Queries.GetAttachmentFile;

public record GetAttachmentFileQuery(
    Guid AttachmentId) : IRequest<Result<AttachmentFileResult>>;
