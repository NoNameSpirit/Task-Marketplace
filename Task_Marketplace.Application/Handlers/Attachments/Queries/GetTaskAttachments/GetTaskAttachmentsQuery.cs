using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Task_Marketplace.Application.Handlers.Attachments.Queries.GetTaskAttachments;

public record GetTaskAttachmentsQuery(
    Guid TaskId) : IRequest<Result<List<TaskAttachmentDto>>>;
