using Domain.Entities;
using Domain.Interfaces.UserActions;

namespace Infrastructure.Repositories.UserActions;

public class UserActionCommandRepository : IUserActionCommandRepository
{
    private readonly AppDbContext _context;

    public UserActionCommandRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(
        UserAction action,
        CancellationToken cancellationToken = default)
    {
        await _context.UserActions.AddAsync(action, cancellationToken);
    }
}