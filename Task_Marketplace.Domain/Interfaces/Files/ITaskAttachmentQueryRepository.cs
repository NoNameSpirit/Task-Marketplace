using Domain.Entities;

namespace Domain.Interfaces.Files;

public interface ITaskAttachmentQueryRepository
{
    Task<TaskAttachment?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<TaskAttachment?> GetTrackedByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IReadOnlyCollection<TaskAttachment>> GetByTaskIdAsync(Guid taskId, CancellationToken cancellationToken = default);
}
