using Domain.Entities;
using Domain.Interfaces.Chats;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Chats;

public class ChatQueryRepository : IChatQueryRepository
{
    private readonly AppDbContext _context;

    public ChatQueryRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Chat?> GetByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        return await _context.Chats
            .AsNoTracking()
            .Include(c => c.Messages.OrderBy(m => m.SentAt))
            .FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
    }

    public async Task<Dictionary<Guid, string>> GetUserNamesAsync(
        IEnumerable<Guid> userIds,
        CancellationToken cancellationToken = default)
    {
        var ids = userIds.Distinct().ToList();

        return await _context.Users
            .AsNoTracking()
            .Where(u => ids.Contains(u.Id))
            .ToDictionaryAsync(u => u.Id, u => u.Name, cancellationToken);
    }

    public async Task<Chat?> GetByIdWithMessagesAsync(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        return await _context.Chats
            .AsNoTracking()
            .Include(c => c.Messages.OrderBy(m => m.SentAt))
            .FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
    }

    public async Task<Chat?> GetByTaskIdAsync(
        Guid taskId,
        CancellationToken cancellationToken = default)
    {
        return await _context.Chats
            .AsNoTracking()
            .Include(c => c.Messages.OrderBy(m => m.SentAt))
            .FirstOrDefaultAsync(c => c.ProjectTaskId == taskId, cancellationToken);
    }

    public async Task<Chat?> GetTrackedByIdAsync(
        Guid id,
        CancellationToken ct = default)
    {
        return await _context.Chats
            .Include(c => c.Messages)
            .FirstOrDefaultAsync(c => c.Id == id, ct);
    }
}
