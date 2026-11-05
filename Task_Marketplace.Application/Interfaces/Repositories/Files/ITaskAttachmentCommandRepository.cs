using Domain.Entities;

namespace Task_Marketplace.Application.Interfaces.Repositories.Files;

public interface ITaskAttachmentCommandRepository
{
    Task AddAsync(TaskAttachment attachment, CancellationToken cancellationToken = default);
}
