using Application.Interfaces;
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
    private readonly IFileStorageService _fileStorage;
    private readonly ICurrentUser _currentUser;

    public DeleteAttachmentHandler(
        ITaskAttachmentQueryRepository attachmentQueryRepository,
        IFileStorageService fileStorage,
        ICurrentUser currentUser)
    {
        _attachmentQueryRepository = attachmentQueryRepository;
        _fileStorage = fileStorage;
        _currentUser = currentUser;
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

        if (attachment.UploadedByUserId != _currentUser.Id)
        {
            return Result.Failure(
                ErrorMessages.OnlyUploaderCanDeleteAttachment,
                ErrorType.Forbidden);
        }

        attachment.Delete();

        var relativePath = $"tasks/{attachment.TaskId}/{attachment.StoredFileName}";

        await _fileStorage.DeleteAsync(relativePath, cancellationToken);

        return Result.Success();
    }
}