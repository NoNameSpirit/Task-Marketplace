using Domain.Entities;
using Domain.Interfaces.Chats;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Chats;

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
    }

    public async Task UpdateAsync(
        Chat chat,
        CancellationToken cancellationToken = default)
    {
        _context.Chats.Update(chat);
    }

    public async Task DeleteAsync(
        Guid chatId,
        CancellationToken cancellationToken = default)
    {
        var deletedChat = await _context.Chats
            .FirstOrDefaultAsync(p => p.Id == chatId, cancellationToken);

        if (deletedChat is not null)
        {
            deletedChat.Delete();
        }
    }
}
