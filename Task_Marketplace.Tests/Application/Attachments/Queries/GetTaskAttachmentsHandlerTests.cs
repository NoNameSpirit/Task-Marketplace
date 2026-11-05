using Application.Mappers;
using Domain.Entities;
using Domain.Interfaces.Files;
using FluentAssertions;
using NSubstitute;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Task_Marketplace.Application.Handlers.Attachments.Queries.GetTaskAttachments;
using Xunit;

namespace Task_Marketplace.Tests.Application.Attachments.Queries;

public class GetTaskAttachmentsHandlerTests
{
    private ITaskAttachmentQueryRepository _attachmentQueryRepository = Substitute.For<ITaskAttachmentQueryRepository>();
    private GetTaskAttachmentsHandler _handler;

    private Guid _taskId = Guid.NewGuid();

    public GetTaskAttachmentsHandlerTests()
    {
        _handler = new GetTaskAttachmentsHandler(_attachmentQueryRepository);
    }

    [Fact]
    public async Task Handle_CorrectData_ReturnSucccess()
    {
        var query = new GetTaskAttachmentsQuery(_taskId);
        var taskAttacmentList = new List<TaskAttachment>() { TaskAttachment.Create(Guid.NewGuid(), Guid.NewGuid(), "OriginalFileName", "StoredFileName", "ContentType", 1024L).Value! };
        var expectedResult = Result<List<TaskAttachmentDto>>.Success(
            TaskAttachmentMapper.ToDtoList(taskAttacmentList));

        _attachmentQueryRepository
            .GetByTaskIdAsync(Arg.Any<Guid>(), Arg.Any<CancellationToken>())
            .Returns(taskAttacmentList);

        var result = await _handler.Handle(query, CancellationToken.None);


        result.IsSuccess.Should().BeTrue();
        result.Value.Should().HaveCount(1);
        result.Value![0].OriginalFileName.Should().Be("OriginalFileName");
        result.Value![0].ContentType.Should().Be("ContentType");
    }
}
