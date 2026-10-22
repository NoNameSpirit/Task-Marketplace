using Application.Mappers;
using Domain.Interfaces.Files;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.Attachments.Queries;

public class GetTaskAttachmentsHandler
    : IRequestHandler<GetTaskAttachmentsQuery, Result<List<TaskAttachmentDto>>>
{
    private readonly ITaskAttachmentQueryRepository _attachmentQueryRepository;

    public GetTaskAttachmentsHandler(
        ITaskAttachmentQueryRepository attachmentQueryRepository)
    {
        _attachmentQueryRepository = attachmentQueryRepository;
    }

    public async Task<Result<List<TaskAttachmentDto>>> Handle(
        GetTaskAttachmentsQuery request,
        CancellationToken cancellationToken = default)
    {
        var attachments = await _attachmentQueryRepository.GetByTaskIdAsync(
            request.TaskId,
            cancellationToken);

        return Result<List<TaskAttachmentDto>>.Success(
            TaskAttachmentMapper.ToDtoList(attachments));
    }
}