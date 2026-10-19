using Application.Interfaces;
using Application.Mappers;
using Application.Services.FileStorage;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.Files;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;

namespace Application.Attachments.Commands.UploadAttachment;

public class UploadAttachmentHandler
    : IRequestHandler<UploadAttachmentCommand, Result<TaskAttachmentDto>>
{
    private readonly IProjectTaskQueryRepository _taskQueryRepository;
    private readonly ITaskAttachmentCommandRepository _attachmentCommandRepository;
    private readonly IFileStorageService _fileStorage;
    private readonly ICurrentUser _currentUser;

    public UploadAttachmentHandler(
        IProjectTaskQueryRepository taskQueryRepository,
        ITaskAttachmentCommandRepository attachmentCommandRepository,
        IFileStorageService fileStorage,
        ICurrentUser currentUser)
    {
        _taskQueryRepository = taskQueryRepository;
        _attachmentCommandRepository = attachmentCommandRepository;
        _fileStorage = fileStorage;
        _currentUser = currentUser;
    }

    public async Task<Result<TaskAttachmentDto>> Handle(
        UploadAttachmentCommand request,
        CancellationToken cancellationToken = default)
    {
        var task = await _taskQueryRepository.GetTrackedByIdAsync(
            request.TaskId,
            cancellationToken);

        if (task is null)
        {
            return Result<TaskAttachmentDto>.Failure(
                ErrorMessages.ProjectTaskNotFound,
                ErrorType.NotFound);
        }

        if (task.Status == ProjectTaskStatus.Done
            || task.Status == ProjectTaskStatus.Cancelled)
        {
            return Result<TaskAttachmentDto>.Failure(
                ErrorMessages.CannotAttachToClosedTask,
                ErrorType.Validation);
        }

        if (task.CustomerId != _currentUser.Id
            && task.ExecutorId != _currentUser.Id)
        {
            return Result<TaskAttachmentDto>.Failure(
                ErrorMessages.OnlyParticipantsCanAttach,
                ErrorType.Forbidden);
        }

        var extension = Path.GetExtension(request.FileName)
            .ToLowerInvariant();

        var storedFileName = $"{Guid.NewGuid():N}{extension}";

        var createResult = TaskAttachment.Create(
            request.TaskId,
            _currentUser.Id,
            request.FileName,
            storedFileName,
            request.ContentType,
            request.Size);

        if (!createResult.IsSuccess)
        {
            return Result<TaskAttachmentDto>.Failure(
                createResult.Message,
                ErrorType.Validation);
        }

        var attachment = createResult.Value!;
        var relativePath = $"tasks/{request.TaskId}/{storedFileName}";

        await _fileStorage.SaveAsync(
            request.Content,
            relativePath,
            cancellationToken);

        await _attachmentCommandRepository.AddAsync(attachment, cancellationToken);

        return Result<TaskAttachmentDto>.Success(TaskAttachmentMapper.ToDto(attachment));
    }
}