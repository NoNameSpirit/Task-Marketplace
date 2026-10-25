using Domain.Constants;
using Domain.Entities;
using FluentAssertions;
using Shared.Dtos.Responses;
using Xunit;

namespace Task_Marketplace.Tests.Domain.Entities;

public class TaskAttachmentTests
{
    private Guid _taskId = Guid.NewGuid();
    private Guid _uploadedByUserId = Guid.NewGuid();
    private const string _originalFileName = "OriginalFileName";
    private const string _storedFileName = "StoredFileName";
    private const string _contentType = "ContentType";
    private const long _sizeBytes = 1024L;

    [Fact]
    public void Create_TaskIdIsEmpty_ReturnFailure()
    {
        var expectedResult = Result<TaskAttachment>.Failure(ErrorMessages.TaskIdCannotBeEmpty);

        var result = TaskAttachment.Create(Guid.Empty, _uploadedByUserId, _originalFileName, _storedFileName, _contentType, _sizeBytes);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Create_UploadedByUserIdIsEmpty_ReturnFailure()
    {
        var expectedResult = Result<TaskAttachment>.Failure(ErrorMessages.UploadedByUserIdCannotBeEmpty);

        var result = TaskAttachment.Create(_taskId, Guid.Empty, _originalFileName, _storedFileName, _contentType, _sizeBytes);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Create_OriginalFileNameIsEmpty_ReturnFailure()
    {
        var expectedResult = Result<TaskAttachment>.Failure(ErrorMessages.OriginalFileNameCannotBeEmpty);

        var result = TaskAttachment.Create(_taskId, _uploadedByUserId, string.Empty, _storedFileName, _contentType, _sizeBytes);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Create_NegativeSizeOfBytes_ReturnFailure()
    {
        var expectedResult = Result<TaskAttachment>.Failure(ErrorMessages.FileSizeMustBePositive);

        var result = TaskAttachment.Create(_taskId, _uploadedByUserId, _originalFileName, _storedFileName, _contentType, -100);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Create_SizeOfBytesMoreThanLimit_ReturnFailure()
    {
        var bytesMoreThanLimit = AttachmentConstants.MaxSizeBytes + 1;
        var expectedResult = Result<TaskAttachment>.Failure(string.Format(
                ErrorMessages.FileSizeExceedsLimit,
                AttachmentConstants.MaxSizeBytes / (1024 * 1024)));

        var result = TaskAttachment.Create(_taskId, _uploadedByUserId, _originalFileName, _storedFileName, _contentType, bytesMoreThanLimit);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Create_CorrectData_ReturnSuccess()
    {
        var result = TaskAttachment.Create(_taskId, _uploadedByUserId, _originalFileName, _storedFileName, _contentType, _sizeBytes);

        result.IsSuccess.Should().BeTrue();
        result.Value!.TaskId.Should().Be(_taskId);
        result.Value!.UploadedByUserId.Should().Be(_uploadedByUserId);
    }
}