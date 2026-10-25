using MediatR;
using Shared.Dtos.Responses.ProjectTasks;
using System.Security.Claims;
using Task_Marketplace.Application.Handlers.Attachments.Queries.GetAttachmentFile;
using Task_Marketplace.Shared.Dtos.Requests.Attachments.Queries;

namespace Web_Api.Controllers.Attachments;

public class DownloadEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<GetAttachmentFileRequest, AttachmentFileResult>
{
    public override void Configure()
    {
        Get("{attachmentId:guid}/download");
        Group<TaskAttachmentGroup>();
        Claims(ClaimTypes.NameIdentifier);
    }

    public override async Task HandleAsync(
        GetAttachmentFileRequest request,
        CancellationToken cancellationToken = default)
    {
        var query = new GetAttachmentFileQuery(request.AttachmentId);

        var result = await _mediatr.Send(query, cancellationToken);

        if (await SendIfFailureAsync(result, cancellationToken))
        {
            return;
        }

        await Send.OkAsync(result.Value!, cancellationToken);
    }
}