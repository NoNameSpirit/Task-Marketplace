using MediatR;
using System.Security.Claims;
using Task_Marketplace.Application.Handlers.Attachments.Commands.DeleteAttachment;
using Task_Marketplace.Shared.Dtos.Requests.Attachments.Commands;

namespace Web_Api.Controllers.Attachments;

public class DeleteEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<DeleteAttachmentRequest, object>
{
    public override void Configure()
    {
        Delete("{attachmentId}");
        Group<TaskAttachmentGroup>();
        Claims(ClaimTypes.NameIdentifier);
    }

    public override async Task HandleAsync(
        DeleteAttachmentRequest request,
        CancellationToken cancellationToken = default)
    {
        var command = new DeleteAttachmentCommand(request.AttachmentId);

        var result = await _mediatr.Send(command, cancellationToken);

        if (await SendIfFailureAsync(result, cancellationToken))
        {
            return;
        }

        await Send.NoContentAsync(cancellationToken);
    }
}