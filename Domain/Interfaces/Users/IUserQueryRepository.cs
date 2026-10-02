using Domain.Entities;
using Shared.Dtos.Responses;

namespace Domain.Interfaces.Users;

public interface IUserQueryRepository
{
    Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<User?> GetByNameAsync(string name, CancellationToken cancellationToken = default);
    Task<PagedResult<User>> GetAllAsync(int page, int pageSize, CancellationToken cancellationToken = default);
    Task<PagedResult<User>> SearchByNameAsync(string searchQuery, int page, int pageSize, CancellationToken cancellationToken = default);
    Task<User?> GetTrackedByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<Dictionary<Guid, string>> GetNamesByIdsAsync(IReadOnlyCollection<Guid> ids, CancellationToken cancellationToken = default);
    Task<PagedResult<User>> GetPagedAsync(int page, int pageSize, CancellationToken cancellationToken = default);
}
