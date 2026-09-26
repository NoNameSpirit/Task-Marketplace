using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<ProjectTask> ProjectTasks { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Chat> Chats { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasQueryFilter(u => !u.IsDeleted);

        modelBuilder.Entity<ProjectTask>()
            .HasQueryFilter(u => !u.IsDeleted);

        modelBuilder.Entity<Message>()
            .HasQueryFilter(u => !u.IsDeleted);

        modelBuilder.Entity<Chat>()
            .HasQueryFilter(u => !u.IsDeleted);
    }
}
