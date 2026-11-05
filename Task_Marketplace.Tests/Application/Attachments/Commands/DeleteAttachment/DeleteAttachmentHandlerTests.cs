using Application.Interfaces;
using Application.Services.FileStorage;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Files;
using FluentAssertions;
using NSubstitute;
using Shared.Dtos.Responses;
using Shared.Enums;
using Task_Marketplace.Application.Handlers.Attachments.Commands.DeleteAttachment;
using Xunit;

namespace Task_Marketplace.Tests.Application.Attachments.Commands.DeleteAttachment;

public class DeleteAttachmentHandlerTests
{
    private ITaskAttachmentQueryRepository _attachmentQueryRepository = Substitute.For<ITaskAttachmentQueryRepository>();
    private IFileStorageService _fileStorage = Substitute.For<IFileStorageService>();
    private ICurrentUser _currentUser = Substitute.For<ICurrentUser>();
    private IUnitOfWork _unitOfWork = Substitute.For<IUnitOfWork>();
    private DeleteAttachmentHandler _handler;

    private Guid _attachmentId = Guid.NewGuid();

    public DeleteAttachmentHandlerTests()
    {
        _handler = new DeleteAttachmentHandler(_attachmentQueryRepository, _fileStorage, _currentUser, _unitOfWork);
    }

    [Fact]
    public async Task Handle_AttachmentIsNull_ReturnFailure()
    {
        var command = new DeleteAttachmentCommand(_attachmentId);
        var expectedResult = Result.Failure(
                ErrorMessages.TaskAttachmentNotFound,
                ErrorType.NotFound);

        _attachmentQueryRepository
             .GetTrackedByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns((TaskAttachment?)null);

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_UploadedUserIsNotCorrect_ReturnFailure()
    {
        var command = new DeleteAttachmentCommand(_attachmentId);
        var expectedResult = Result.Failure(
                ErrorMessages.OnlyUploaderCanDeleteAttachment,
                ErrorType.Forbidden);
        var taskAttacment = TaskAttachment.Create(Guid.NewGuid(), Guid.NewGuid(), "OriginalFileName", "StoredFileName", "ContentType", 1024L).Value!;

        _attachmentQueryRepository
             .GetTrackedByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(taskAttacment);

        _currentUser.Id
            .Returns(Guid.NewGuid());

        var result = await _handler.Handle(command, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var command = new DeleteAttachmentCommand(_attachmentId);
        var expectedResult = Result.Success();
        var uploadedByUser = Guid.NewGuid();
        var taskAttacment = TaskAttachment.Create(Guid.NewGuid(), uploadedByUser, "OriginalFileName", "StoredFileName", "ContentType", 1024L).Value!;

        _attachmentQueryRepository
             .GetTrackedByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(taskAttacment);

        _currentUser.Id
            .Returns(uploadedByUser);

        var result = await _handler.Handle(command, CancellationToken.None);

        await _unitOfWork.Received(1).SaveChangesAsync(Arg.Any<CancellationToken>());
        await _fileStorage.Received(1).DeleteAsync(Arg.Any<string>(), Arg.Any<CancellationToken>());
        result.Should().Be(expectedResult);
    }

}
