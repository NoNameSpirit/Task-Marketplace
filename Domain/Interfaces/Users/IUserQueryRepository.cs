using Domain.Entities;
using Domain.Shared;

namespace Domain.Interfaces.Users;

public interface IUserQueryRepository
{
    Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<PagedResult<User>> GetAllAsync(int page, int pageSize, CancellationToken cancellationToken = default);
    Task<PagedResult<User>> SearchByNameAsync(string searchQuery, int page, int pageSize, CancellationToken cancellationToken = default);
}
