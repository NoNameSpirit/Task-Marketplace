using Domain.Entities;
using Domain.Interfaces.Users;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Users;

public class UserCommandRepository : IUserCommandRepository
{
    private readonly AppDbContext _context;

    public UserCommandRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(
        User user,
        CancellationToken cancellationToken = default)
    {
        await _context.Users.AddAsync(user, cancellationToken);

        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateAsync(
        User user,
        CancellationToken cancellationToken = default)
    {
        _context.Users.Update(user);

        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteAsync(
        Guid userId,
        CancellationToken cancellationToken = default)
    {
        var deletedUser = await _context.Users
            .FirstOrDefaultAsync(p => p.Id == userId, cancellationToken);

        if (deletedUser is not null)
        {
            deletedUser.Delete();

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
