using Application.Common;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.Attachments.Commands.UploadAttachment;

public record UploadAttachmentCommand(
    Guid TaskId,
    Guid UploadedByUserId,
    string FileName,
    string ContentType,
    long Size,
    Stream Content) : IRequest<Result<TaskAttachmentDto>>, IUserCommand
{
    public Guid UserId => UploadedByUserId;
}