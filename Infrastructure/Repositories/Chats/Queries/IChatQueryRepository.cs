using Domain.Entities;

namespace Infrastructure.Repositories.Chats.Queries;

public interface IChatQueryRepository
{
    Task<Chat?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<Chat?> GetByIdWithMessagesAsync(Guid id, CancellationToken cancellationToken = default);

    Task<Chat?> GetByTaskIdAsync(Guid taskId, CancellationToken cancellationToken = default);
}
