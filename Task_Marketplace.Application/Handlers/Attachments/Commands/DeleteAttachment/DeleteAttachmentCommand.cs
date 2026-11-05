using MediatR;
using Shared.Dtos.Responses;

namespace Task_Marketplace.Application.Handlers.Attachments.Commands.DeleteAttachment;

public record DeleteAttachmentCommand(
    Guid AttachmentId) : IRequest<Result>;