using Domain.Entities;

namespace Domain.Interfaces.Chats;

public interface IChatQueryRepository
{
    Task<Chat?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<Chat?> GetByIdWithMessagesAsync(Guid id, CancellationToken cancellationToken = default);
    Task<Chat?> GetByTaskIdAsync(Guid taskId, CancellationToken cancellationToken = default);
    Task<Chat?> GetTrackedByIdAsync(Guid id, CancellationToken ct = default);
    Task<Dictionary<Guid, string>> GetUserNamesAsync(IEnumerable<Guid> userIds, CancellationToken cancellationToken = default);
}
