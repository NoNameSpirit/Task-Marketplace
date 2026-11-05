using Application.Services.FileStorage;
using Domain.Constants;
using Domain.Interfaces.Files;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;

namespace Task_Marketplace.Application.Handlers.Attachments.Queries.GetAttachmentFile;

public class GetAttachmentFileHandler
    : IRequestHandler<GetAttachmentFileQuery, Result<AttachmentFileResult>>
{
    private readonly ITaskAttachmentQueryRepository _attachmentQueryRepository;
    private readonly IFileStorageService _fileStorage;

    public GetAttachmentFileHandler(
        ITaskAttachmentQueryRepository attachmentQueryRepository,
        IFileStorageService fileStorage)
    {
        _attachmentQueryRepository = attachmentQueryRepository;
        _fileStorage = fileStorage;
    }

    public async Task<Result<AttachmentFileResult>> Handle(
        GetAttachmentFileQuery request,
        CancellationToken cancellationToken = default)
    {
        var attachment = await _attachmentQueryRepository.GetByIdAsync(
            request.AttachmentId,
            cancellationToken);

        if (attachment is null)
        {
            return Result<AttachmentFileResult>.Failure(
                ErrorMessages.TaskAttachmentNotFound,
                ErrorType.NotFound);
        }

        var relativePath = $"tasks/{attachment.TaskId}/{attachment.StoredFileName}";

        var fileResult = await _fileStorage.OpenReadAsync(
            relativePath,
            cancellationToken);

        if (!fileResult.IsSuccess)
        {
            return Result<AttachmentFileResult>.Failure(
                fileResult.Message,
                ErrorType.NotFound);
        }

        await using var stream = fileResult.Value!;

        using var ms = new MemoryStream();
        await stream.CopyToAsync(ms, cancellationToken);

        var result = new AttachmentFileResult
        {
            FileName = attachment.OriginalFileName,
            ContentType = attachment.ContentType,
            Content = ms.ToArray()
        };

        return Result<AttachmentFileResult>.Success(result);
    }
}