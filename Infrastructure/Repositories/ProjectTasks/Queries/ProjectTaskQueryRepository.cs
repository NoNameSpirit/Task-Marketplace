using Domain.Constants;
using Domain.Entities;
using Domain.Enums.Task;
using Domain.Shared;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.ProjectTasks.Queries;

public class ProjectTaskQueryRepository : IProjectTaskQueryRepository
{
    private readonly AppDbContext _context;

    public ProjectTaskQueryRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<ProjectTask?> GetByIdAsync(
        Guid projectTaskId,
        CancellationToken cancellationToken = default)
    {
        var projectTask = await _context.ProjectTasks
           .AsNoTracking()
           .FirstOrDefaultAsync(p => p.Id == projectTaskId, cancellationToken);

        return projectTask;
    }

    public async Task<PagedResult<ProjectTask>> GetPublishedAsync(
        int page,
        int pageSize,
        CancellationToken cancellationToken = default)
    {
        var query = _context.ProjectTasks
           .AsNoTracking()
           .Where(t => t.Status == ProjectTaskStatus.Published)
           .OrderByDescending(t => t.StartsAt);

        var totalCount = await query.CountAsync(cancellationToken);

        if (totalCount == CurrencyConstants.ZeroElements)
        {
            return PagedResult<ProjectTask>.Empty(page, pageSize);
        }

        var items = await query
            .Skip((page - CurrencyConstants.OffsetPage) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);

        return PagedResult<ProjectTask>.Create(items, page, pageSize, totalCount);
    }

    public async Task<PagedResult<ProjectTask>> GetByCustomerIdAsync(
        Guid CustomerId,
        int page,
        int pageSize,
        CancellationToken cancellationToken = default)
    {
        var query = _context.ProjectTasks
           .AsNoTracking()
           .Where(t => t.CustomerId == CustomerId)
           .OrderByDescending(t => t.StartsAt);

        var totalCount = await query.CountAsync(cancellationToken);

        if (totalCount == CurrencyConstants.ZeroElements)
        {
            return PagedResult<ProjectTask>.Empty(page, pageSize);
        }

        var items = await query
            .Skip((page - CurrencyConstants.OffsetPage) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);

        return PagedResult<ProjectTask>.Create(items, page, pageSize, totalCount);
    }

    public async Task<IReadOnlyCollection<ProjectTask>> GetOverdueAsync(
        CancellationToken cancellationToken = default)
    {
        var items = await _context.ProjectTasks
            .AsNoTracking()
            .Where(t => t.EndsAt < DateTimeOffset.UtcNow && t.Status == ProjectTaskStatus.InProgress)
            .ToListAsync(cancellationToken);

        return items;
    }
}
