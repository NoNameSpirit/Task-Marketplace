using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.Attachments.Queries;

public record GetTaskAttachmentsQuery(
    Guid TaskId) : IRequest<Result<List<TaskAttachmentDto>>>;
