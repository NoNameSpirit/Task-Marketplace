using Domain.Entities;

namespace Domain.Interfaces.Files;

public interface ITaskAttachmentCommandRepository
{
    Task AddAsync(TaskAttachment attachment, CancellationToken cancellationToken = default);
}
