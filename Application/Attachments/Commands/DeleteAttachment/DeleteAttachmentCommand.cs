using Application.Common;
using MediatR;
using Shared.Dtos.Responses;

namespace Application.Attachments.Commands.DeleteAttachment;

public record DeleteAttachmentCommand(
    Guid AttachmentId,
    Guid CurrentUserId) : IRequest<Result>, IUserCommand
{
    public Guid UserId => CurrentUserId;
}