using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.UserActions;
using Microsoft.EntityFrameworkCore;
using Shared.Dtos.Responses;

namespace Infrastructure.Repositories.UserActions;

public class UserActionQueryRepository : IUserActionQueryRepository
{
    private readonly AppDbContext _context;

    public UserActionQueryRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<PagedResult<UserAction>> GetAsync(
        Guid? userId,
        int? actionType,
        int page,
        int pageSize,
        CancellationToken cancellationToken = default)
    {
        var query = _context.UserActions
            .AsNoTracking()
            .OrderByDescending(a => a.PerformedAt)
            .AsQueryable();

        if (userId.HasValue)
        {
            query = query.Where(a => a.UserId == userId.Value);
        }

        if (actionType.HasValue)
        {
            query = query.Where(a => (int)a.ActionType == actionType.Value);
        }

        var totalCount = await query.CountAsync(cancellationToken);

        if (totalCount == CurrencyConstants.ZeroElements)
        {
            return PagedResult<UserAction>.Empty(page, pageSize);
        }

        var items = await query
            .Skip((page - CurrencyConstants.OffsetPage) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);

        return PagedResult<UserAction>.Create(items, page, pageSize, totalCount);
    }
}