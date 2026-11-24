using Domain.Entities;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shared.Enums;
using Testcontainers.MsSql;
using Xunit;

namespace Task_Marketplace.Tests.Integration.Infrastructure;

public class IntegrationTestFixture : IAsyncLifetime
{
    private readonly MsSqlContainer _database = new MsSqlBuilder("mcr.microsoft.com/mssql/server:2022-latest").Build();

    public CustomWebApplicationFactory Factory { get; private set; } = null!;
    public HttpClient Client { get; private set; } = null!;

    public async Task InitializeAsync()
    {
        await _database.StartAsync();
        Factory = new CustomWebApplicationFactory(_database.GetConnectionString());
        Client = Factory.CreateClient();

        using var scope = Factory.Services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

        await db.Database.MigrateAsync();

        if (!await db.Users.AnyAsync(u => u.Role == UserRole.Admin && !u.IsDeleted))
        {
            var hash = BCrypt.Net.BCrypt.HashPassword(TestConstants.Password);
            var user = User.Create("seed-admin", hash, UserRole.Customer).Value!;
            db.Users.Add(user);
            await db.SaveChangesAsync();

            await db.Database.ExecuteSqlRawAsync(
                "UPDATE Users SET Role = {0} WHERE Id = {1}",
                (int)UserRole.Admin, user.Id);
        }
    }

    public async Task DisposeAsync()
    {
        Client.Dispose();
        await Factory.DisposeAsync();
        await _database.DisposeAsync();
    }
}