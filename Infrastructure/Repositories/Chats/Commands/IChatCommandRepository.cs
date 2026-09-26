using Domain.Entities;

namespace Infrastructure.Repositories.Chats.Commands;

public interface IChatCommandRepository
{
    Task AddAsync(Chat chat, CancellationToken cancellationToken = default);
    Task UpdateAsync(Chat chat, CancellationToken cancellationToken = default);
    Task DeleteAsync(Chat chat, CancellationToken cancellationToken = default);
}
