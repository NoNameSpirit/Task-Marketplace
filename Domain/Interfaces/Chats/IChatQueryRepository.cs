using Domain.Entities;

namespace Domain.Interfaces.Chats;

public interface IChatQueryRepository
{
    Task<Chat?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<Chat?> GetByIdWithMessagesAsync(Guid id, CancellationToken cancellationToken = default);

    Task<Chat?> GetByTaskIdAsync(Guid taskId, CancellationToken cancellationToken = default);
}
