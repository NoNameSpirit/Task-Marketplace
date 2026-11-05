using Domain.Entities;
using Task_Marketplace.Application.Interfaces.Repositories.Files;

namespace Infrastructure.Repositories.Files;

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