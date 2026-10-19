using Application.Attachments.Commands.DeleteAttachment;
using Application.Attachments.Commands.UploadAttachment;
using Application.Attachments.Queries;
using Application.Attachments.Queries.GetAttachmentFile;
using Domain.Constants;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web_Api.Extensions;

namespace Web_Api.Controllers;

[ApiController]
[Route("api/tasks/{taskId}/attachments")]
[Authorize]
public class TaskAttachmentsController : ControllerBase
{
    private readonly IMediator _mediatr;

    public TaskAttachmentsController(IMediator mediatr)
    {
        _mediatr = mediatr;
    }

    [HttpGet("{attachmentId:guid}/download")]
    public async Task<IActionResult> Download(
        Guid taskId,
        Guid attachmentId,
        CancellationToken cancellationToken)
    {
        var query = new GetAttachmentFileQuery(attachmentId);

        var result = await _mediatr.Send(query, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpGet]
    public async Task<IActionResult> List(
        Guid taskId,
        CancellationToken cancellationToken)
    {
        var query = new GetTaskAttachmentsQuery(taskId);

        var result = await _mediatr.Send(query, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpPost]
    [RequestSizeLimit(AttachmentConstants.MaxSizeBytes)]
    [RequestFormLimits(MultipartBodyLengthLimit = AttachmentConstants.MaxSizeBytes)]
    public async Task<IActionResult> Upload(
        Guid taskId,
        [FromForm] IFormFile file,
        CancellationToken cancellationToken)
    {
        if (file is null || file.Length == 0)
        {
            return BadRequest(ErrorMessages.OriginalFileNameCannotBeEmpty);
        }

        await using var stream = file.OpenReadStream();

        var command = new UploadAttachmentCommand(
            taskId,
            file.FileName,
            file.ContentType,
            file.Length,
            stream);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpDelete("{attachmentId}")]
    public async Task<IActionResult> Delete(
        Guid taskId,
        Guid attachmentId,
        CancellationToken cancellationToken)
    {
        var command = new DeleteAttachmentCommand(attachmentId);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }
}