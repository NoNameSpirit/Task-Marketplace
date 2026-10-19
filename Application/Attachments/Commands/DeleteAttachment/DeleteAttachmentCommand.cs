using MediatR;
using Shared.Dtos.Responses;

namespace Application.Attachments.Commands.DeleteAttachment;

public record DeleteAttachmentCommand(
    Guid AttachmentId) : IRequest<Result>;