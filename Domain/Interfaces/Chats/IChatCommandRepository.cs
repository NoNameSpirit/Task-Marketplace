using Domain.Entities;

namespace Domain.Interfaces.Chats;

public interface IChatCommandRepository
{
    Task AddAsync(Chat chat, CancellationToken cancellationToken = default);
    Task UpdateAsync(Chat chat, CancellationToken cancellationToken = default);
    Task DeleteAsync(Guid chatId, CancellationToken cancellationToken = default);
    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}
