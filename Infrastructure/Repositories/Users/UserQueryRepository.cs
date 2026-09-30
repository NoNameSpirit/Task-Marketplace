using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.Users;
using Microsoft.EntityFrameworkCore;
using Shared.Dtos;

namespace Infrastructure.Repositories.Users;

public class UserQueryRepository : IUserQueryRepository
{
    private readonly AppDbContext _context;

    public UserQueryRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<User?> GetByIdAsync(
        Guid userId,
        CancellationToken cancellationToken = default)
    {
        return await _context.Users
            .AsNoTracking()
            .FirstOrDefaultAsync(u => u.Id == userId, cancellationToken);
    }

    public async Task<User?> GetByNameAsync(
        string name,
        CancellationToken cancellationToken = default)
    {
        var user = _context.Users
            .AsNoTracking()
            .FirstOrDefault(u => u.Name == name);

        return user;
    }

    public async Task<PagedResult<User>> GetAllAsync(
        int page,
        int pageSize,
        CancellationToken cancellationToken = default)
    {
        var query = _context.Users
            .AsNoTracking()
            .OrderBy(u => u.Name);

        var totalCount = await query.CountAsync(cancellationToken);

        if (totalCount == CurrencyConstants.ZeroElements)
        {
            return PagedResult<User>.Empty(page, pageSize);
        }

        var items = await query
            .Skip((page - CurrencyConstants.OffsetPage) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);

        return PagedResult<User>.Create(items, page, pageSize, totalCount);
    }

    public async Task<PagedResult<User>> SearchByNameAsync(
        string searchQuery,
        int page,
        int pageSize,
        CancellationToken cancellationToken = default)
    {
        var query = _context.Users
            .AsNoTracking()
            .Where(u => u.Name.Contains(searchQuery))
            .OrderBy(u => u.Name);

        var totalCount = await query.CountAsync(cancellationToken);

        if (totalCount == CurrencyConstants.ZeroElements)
        {
            return PagedResult<User>.Empty(page, pageSize);
        }

        var items = await query
            .Skip((page - CurrencyConstants.OffsetPage) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);

        return PagedResult<User>.Create(items, page, pageSize, totalCount);
    }
}
