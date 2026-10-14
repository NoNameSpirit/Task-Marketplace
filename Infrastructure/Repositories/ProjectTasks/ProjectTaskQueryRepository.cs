using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.ProjectTasks;
using Microsoft.EntityFrameworkCore;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;

namespace Infrastructure.Repositories.ProjectTasks;

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
           .Include(t => t.Responses)
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

    public async Task<List<TaskResponseDto>> GetResponsesByTaskIdAsync(
        Guid taskId,
        CancellationToken cancellationToken = default)
    {
        var task = await _context.ProjectTasks
            .Include(t => t.Responses)
            .FirstOrDefaultAsync(t => t.Id == taskId, cancellationToken);

        if (task is null || !task.Responses.Any())
        {
            return new List<TaskResponseDto>();
        }

        var executorIds = task.Responses
            .Select(r => r.ExecutorId)
            .Distinct()
            .ToList();

        var users = await _context.Users
            .Where(u => executorIds.Contains(u.Id))
            .ToDictionaryAsync(u => u.Id, u => new { u.Name, u.Rating }, cancellationToken);

        var responses = task.Responses
            .Where(r => users.ContainsKey(r.ExecutorId))
            .Select(r => new TaskResponseDto
            {
                ExecutorId = r.ExecutorId,
                ExecutorName = users[r.ExecutorId].Name,
                ExecutorRating = users[r.ExecutorId].Rating,
                RespondedAt = r.RespondedAt
            })
            .ToList();

        return responses;
    }

    public async Task<ProjectTask?> GetTrackedByIdAsync(
        Guid projectTaskId,
        CancellationToken cancellationToken = default)
    {
        return await _context.ProjectTasks
            .Include(p => p.Responses)
            .FirstOrDefaultAsync(p => p.Id == projectTaskId, cancellationToken);
    }

    public async Task<PagedResult<ProjectTask>> GetByExecutorIdAsync(
         Guid executorId,
         int page,
         int pageSize,
         CancellationToken cancellationToken = default)
    {
        var query = _context.ProjectTasks
            .AsNoTracking()
            .Where(t => t.ExecutorId == executorId)
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

    public async Task<IReadOnlyCollection<decimal>> GetRatingsByExecutorAsync(
        Guid executorId,
        CancellationToken cancellationToken = default)
    {
        var ratings = await _context.ProjectTasks
            .AsNoTracking()
            .Where(t => t.ExecutorId == executorId
                     && t.ProjectRating != null
                     && t.Status == ProjectTaskStatus.Done)
            .Select(t => t.ProjectRating!.Value)
            .ToListAsync(cancellationToken);

        return ratings;
    }
    public async Task<PagedResult<ProjectTask>> SearchPublishedAsync(
        string query,
        int page,
        int pageSize,
        CancellationToken cancellationToken = default)
    {
        var search = _context.ProjectTasks
            .AsNoTracking()
            .Include(t => t.Responses)
            .Where(t => t.Status == ProjectTaskStatus.Published
                     && t.Title.Contains(query))
            .OrderByDescending(t => t.StartsAt);

        var totalCount = await search.CountAsync(cancellationToken);

        if (totalCount == CurrencyConstants.ZeroElements)
        {
            return PagedResult<ProjectTask>.Empty(page, pageSize);
        }

        var items = await search
            .Skip((page - CurrencyConstants.OffsetPage) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);

        return PagedResult<ProjectTask>.Create(items, page, pageSize, totalCount);
    }

    public async Task<PagedResult<ProjectTask>> SearchByCustomerIdAsync(
        Guid customerId,
        string query,
        int page,
        int pageSize,
        CancellationToken cancellationToken = default)
    {
        var search = _context.ProjectTasks
            .AsNoTracking()
            .Where(t => t.CustomerId == customerId
                     && t.Title.Contains(query))
            .OrderByDescending(t => t.StartsAt);

        var totalCount = await search.CountAsync(cancellationToken);

        if (totalCount == CurrencyConstants.ZeroElements)
        {
            return PagedResult<ProjectTask>.Empty(page, pageSize);
        }

        var items = await search
            .Skip((page - CurrencyConstants.OffsetPage) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);

        return PagedResult<ProjectTask>.Create(items, page, pageSize, totalCount);
    }
}
