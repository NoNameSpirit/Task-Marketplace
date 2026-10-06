using Application.Services.FileStorage;
using Domain.Constants;
using Domain.Interfaces.Files;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Attachments.Commands.DeleteAttachment;

public class DeleteAttachmentHandler
    : IRequestHandler<DeleteAttachmentCommand, Result>
{
    private readonly ITaskAttachmentQueryRepository _attachmentQueryRepository;
    private readonly ITaskAttachmentCommandRepository _attachmentCommandRepository;
    private readonly IFileStorageService _fileStorage;

    public DeleteAttachmentHandler(
        ITaskAttachmentQueryRepository attachmentQueryRepository,
        ITaskAttachmentCommandRepository attachmentCommandRepository,
        IFileStorageService fileStorage)
    {
        _attachmentQueryRepository = attachmentQueryRepository;
        _attachmentCommandRepository = attachmentCommandRepository;
        _fileStorage = fileStorage;
    }

    public async Task<Result> Handle(
        DeleteAttachmentCommand request,
        CancellationToken cancellationToken = default)
    {
        var attachment = await _attachmentQueryRepository.GetTrackedByIdAsync(
            request.AttachmentId,
            cancellationToken);

        if (attachment is null)
        {
            return Result.Failure(
                ErrorMessages.TaskAttachmentNotFound,
                ErrorType.NotFound);
        }

        if (attachment.UploadedByUserId != request.CurrentUserId)
        {
            return Result.Failure(
                ErrorMessages.OnlyUploaderCanDeleteAttachment,
                ErrorType.Forbidden);
        }

        attachment.Delete();

        await _attachmentCommandRepository.SaveChangesAsync(cancellationToken);

        var relativePath = $"tasks/{attachment.TaskId}/{attachment.StoredFileName}";

        await _fileStorage.DeleteAsync(relativePath, cancellationToken);

        return Result.Success();
    }
}