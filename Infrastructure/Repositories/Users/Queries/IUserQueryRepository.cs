using Domain.Entities;
using Domain.Shared;

namespace Infrastructure.Repositories.Users.Queries;

public interface IUserQueryRepository
{
    Task<User?> GetByIdAsync(Guid id, CancellationToken ct);
    Task<PagedResult<User>> SearchByNameAsync(string searchQuery, int page, int pageSize, CancellationToken ct);
    Task<PagedResult<User>> GetAllAsync(int page, int pageSize, CancellationToken ct);
}
