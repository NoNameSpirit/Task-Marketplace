using FastEndpoints;

namespace Web_Api.Controllers.Attachments;

public class TaskAttachmentGroup : Group
{
    public TaskAttachmentGroup()
    {
        Configure("api/tasks/{taskId}/attachments", ep =>
        {
            ep.Description(b => b.WithTags("Attachments"));
        });
    }
}