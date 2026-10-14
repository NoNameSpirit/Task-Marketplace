using Application.Services.FileStorage;
using Domain.Constants;
using Domain.Interfaces;
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
    private readonly IUnitOfWork _unitOfWork;

    public DeleteAttachmentHandler(
        ITaskAttachmentQueryRepository attachmentQueryRepository,
        ITaskAttachmentCommandRepository attachmentCommandRepository,
        IFileStorageService fileStorage,
        IUnitOfWork unitOfWork)
    {
        _attachmentQueryRepository = attachmentQueryRepository;
        _attachmentCommandRepository = attachmentCommandRepository;
        _fileStorage = fileStorage;
        _unitOfWork = unitOfWork;
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

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        var relativePath = $"tasks/{attachment.TaskId}/{attachment.StoredFileName}";

        await _fileStorage.DeleteAsync(relativePath, cancellationToken);

        return Result.Success();
    }
}