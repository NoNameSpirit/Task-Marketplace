using Application.Attachments.Queries.GetAttachmentFile;
using Application.Services.FileStorage;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.Files;
using FluentAssertions;
using NSubstitute;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;
using Xunit;

namespace Task_Marketplace.Tests.Application.Attachments.Queries;

public class GetAttachmentFileHandlerTests
{
    private ITaskAttachmentQueryRepository _attachmentQueryRepository = Substitute.For<ITaskAttachmentQueryRepository>();
    private IFileStorageService _fileStorage = Substitute.For<IFileStorageService>();
    private GetAttachmentFileHandler _handler;

    private Guid _attachmentId = Guid.NewGuid();

    public GetAttachmentFileHandlerTests()
    {
        _handler = new GetAttachmentFileHandler(_attachmentQueryRepository, _fileStorage);
    }


    [Fact]
    public async Task Handle_AttachmentIsNull_ReturnFailure()
    {
        var query = new GetAttachmentFileQuery(_attachmentId);
        var expectedResult = Result<AttachmentFileResult>.Failure(
                ErrorMessages.TaskAttachmentNotFound,
                ErrorType.NotFound);

        _attachmentQueryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns((TaskAttachment?)null);

        var result = await _handler.Handle(query, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_FileResultIsFailure_ReturnFailure()
    {
        var query = new GetAttachmentFileQuery(_attachmentId);
        var expectedResult = Result<AttachmentFileResult>.Failure(
                "Error message",
                ErrorType.NotFound);

        var taskAttacment = TaskAttachment.Create(Guid.NewGuid(), Guid.NewGuid(), "OriginalFileName", "StoredFileName", "ContentType", 1024L).Value!;

        _attachmentQueryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(taskAttacment);

        _fileStorage
            .OpenReadAsync(Arg.Any<string>(), Arg.Any<CancellationToken>())
            .Returns(Result<Stream>.Failure(expectedResult.Message));

        var result = await _handler.Handle(query, CancellationToken.None);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSuccess()
    {
        var query = new GetAttachmentFileQuery(_attachmentId);
        var fileName = "OriginalFileName";
        var contentType = "ContentType";
        var taskAttacment = TaskAttachment.Create(Guid.NewGuid(), Guid.NewGuid(), fileName, "StoredFileName", contentType, 1024L).Value!;
        var fileAttachment = new AttachmentFileResult
        {
            FileName = taskAttacment.OriginalFileName,
            ContentType = taskAttacment.ContentType,
            Content = Array.Empty<byte>()
        };
        var expectedResult = Result<AttachmentFileResult>.Success(fileAttachment);

        _attachmentQueryRepository
             .GetByIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
             .Returns(taskAttacment);

        var stream = new MemoryStream();
        _fileStorage
            .OpenReadAsync(Arg.Any<string>(), Arg.Any<CancellationToken>())
            .Returns(Result<Stream>.Success(stream));

        var result = await _handler.Handle(query, CancellationToken.None);

        result.IsSuccess.Should().BeTrue();
        result.Value!.FileName.Should().Be(fileName);
        result.Value.ContentType.Should().Be(contentType);
        result.Value.Content.Should().BeEquivalentTo(Array.Empty<byte>());
    }
}
