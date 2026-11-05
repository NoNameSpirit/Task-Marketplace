using Domain.Constants;
using MediatR;
using Shared.Dtos.Responses.ProjectTasks;
using System.Security.Claims;
using Task_Marketplace.Application.Handlers.Attachments.Commands.UploadAttachment;
using Task_Marketplace.Shared.Dtos.Requests.Attachments.Commands;

namespace Web_Api.Controllers.Attachments;

public class UploadEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<UploadAttachmentRequest, TaskAttachmentDto>
{
    public override void Configure()
    {
        Post(string.Empty);
        Group<TaskAttachmentGroup>();
        Claims(ClaimTypes.NameIdentifier);
        AllowFileUploads();
        MaxRequestBodySize(AttachmentConstants.MaxSizeBytes);
    }

    public override async Task HandleAsync(
        UploadAttachmentRequest request,
        CancellationToken cancellationToken = default)
    {
        var file = Files.FirstOrDefault();

        if (file is null || file.Length == 0)
        {
            AddError(ErrorMessages.OriginalFileNameCannotBeEmpty);
            await Send.ErrorsAsync(StatusCodes.Status400BadRequest, cancellationToken);

            return;
        }

        await using var stream = file.OpenReadStream();

        var command = new UploadAttachmentCommand(
            request.TaskId,
            file.FileName,
            file.ContentType,
            file.Length,
            stream);

        var result = await _mediatr.Send(command, cancellationToken);

        if (await SendIfFailureAsync(result, cancellationToken))
        {
            return;
        }

        await Send.OkAsync(result.Value!, cancellationToken);
    }
}