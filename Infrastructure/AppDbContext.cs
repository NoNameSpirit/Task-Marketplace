using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<ProjectTask> ProjectTasks { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Chat> Chats { get; set; }
    public DbSet<TaskResponse> TaskResponses { get; set; }
    public DbSet<UserAction> UserActions { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasQueryFilter(u => !u.IsDeleted);

        modelBuilder.Entity<ProjectTask>()
            .HasQueryFilter(u => !u.IsDeleted)
            .HasMany(p => p.Responses)
            .WithOne(r => r.Task)
            .HasForeignKey(r => r.TaskId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ProjectTask>()
            .Property(r => r.Id)
            .ValueGeneratedNever();

        modelBuilder.Entity<Message>()
            .HasQueryFilter(u => !u.IsDeleted)
            .Property(m => m.Id).ValueGeneratedNever();

        modelBuilder.Entity<TaskResponse>()
            .HasQueryFilter(u => !u.IsDeleted)
            .Property(r => r.Id)
            .ValueGeneratedNever();

        modelBuilder.Entity<Chat>()
            .HasQueryFilter(u => !u.IsDeleted)
            .Property(c => c.Id).ValueGeneratedNever();

        modelBuilder.Entity<UserAction>()
            .HasQueryFilter(a => !a.IsDeleted)
            .Property(a => a.Id)
            .ValueGeneratedNever();

        modelBuilder.Entity<ProjectTask>()
            .Property(t => t.Price)
            .HasPrecision(18, 2);

        modelBuilder.Entity<ProjectTask>()
            .Property(t => t.ProjectRating)
            .HasPrecision(3, 1);

        modelBuilder.Entity<User>()
            .Property(u => u.Rating)
            .HasPrecision(3, 1);
    }
}
