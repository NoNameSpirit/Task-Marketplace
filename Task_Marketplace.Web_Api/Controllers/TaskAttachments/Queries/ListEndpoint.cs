using MediatR;
using Shared.Dtos.Responses.ProjectTasks;
using System.Security.Claims;
using Task_Marketplace.Application.Handlers.Attachments.Queries.GetTaskAttachments;
using Task_Marketplace.Shared.Dtos.Requests.Attachments.Queries;

namespace Web_Api.Controllers.Attachments;

public class ListEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<GetTaskAttachmentsRequest, List<TaskAttachmentDto>>
{
    public override void Configure()
    {
        Get(string.Empty);
        Group<TaskAttachmentGroup>();
        Claims(ClaimTypes.NameIdentifier);
    }

    public override async Task HandleAsync(
        GetTaskAttachmentsRequest request,
        CancellationToken cancellationToken = default)
    {
        var query = new GetTaskAttachmentsQuery(request.TaskId);

        var result = await _mediatr.Send(query, cancellationToken);

        if (await SendIfFailureAsync(result, cancellationToken))
        {
            return;
        }

        await Send.OkAsync(result.Value!, cancellationToken);
    }
}