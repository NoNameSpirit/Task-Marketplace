using Domain.Entities;
using Domain.Interfaces.Files;

namespace Infrastructure.Repositories.ProjectTasks;

public class TaskAttachmentCommandRepository : ITaskAttachmentCommandRepository
{
    private readonly AppDbContext _context;

    public TaskAttachmentCommandRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(
        TaskAttachment attachment,
        CancellationToken cancellationToken = default)
    {
        await _context.TaskAttachments.AddAsync(attachment, cancellationToken);
    }
}