using Domain.Entities;
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
            .FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
    }

    public async Task<Chat?> GetByIdWithMessagesAsync(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        return await _context.Chats
            .AsNoTracking()
            .Include(c => c.Messages)
            .FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
    }

    public async Task<Chat?> GetByTaskIdAsync(
        Guid taskId,
        CancellationToken cancellationToken = default)
    {
        return await _context.Chats
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.ProjectTaskId == taskId, cancellationToken);
    }
}
