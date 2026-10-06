using Domain.Entities;
using Domain.Interfaces.Files;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.ProjectTasks;

public class TaskAttachmentQueryRepository : ITaskAttachmentQueryRepository
{
    private readonly AppDbContext _context;

    public TaskAttachmentQueryRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<TaskAttachment?> GetByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        return await _context.TaskAttachments
            .AsNoTracking()
            .FirstOrDefaultAsync(a => a.Id == id, cancellationToken);
    }

    public async Task<TaskAttachment?> GetTrackedByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        return await _context.TaskAttachments
            .FirstOrDefaultAsync(a => a.Id == id, cancellationToken);
    }

    public async Task<IReadOnlyCollection<TaskAttachment>> GetByTaskIdAsync(
        Guid taskId,
        CancellationToken cancellationToken = default)
    {
        return await _context.TaskAttachments
            .AsNoTracking()
            .Where(a => a.TaskId == taskId)
            .OrderByDescending(a => a.UploadedAt)
            .ToListAsync(cancellationToken);
    }
}