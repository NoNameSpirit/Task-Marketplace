using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Chats.Commands;

public class ChatCommandRepository : IChatCommandRepository
{
    private readonly AppDbContext _context;

    public ChatCommandRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(
        Chat chat,
        CancellationToken cancellationToken = default)
    {
        await _context.Chats.AddAsync(chat, cancellationToken);

        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateAsync(
        Chat chat,
        CancellationToken cancellationToken = default)
    {
        _context.Chats.Update(chat);

        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteAsync(
        Chat chat,
        CancellationToken cancellationToken = default)
    {
        var deletedChat = await _context.Chats
            .FirstOrDefaultAsync(p => p.Id == chat.Id, cancellationToken);

        if (deletedChat is not null)
        {
            deletedChat.Delete();

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
