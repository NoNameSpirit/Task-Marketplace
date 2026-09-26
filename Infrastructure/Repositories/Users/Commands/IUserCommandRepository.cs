using Domain.Entities;

namespace Infrastructure.Repositories.Users.Commands;

public interface IUserCommandRepository
{
    Task AddAsync(User user, CancellationToken cancellationToken = default);
    Task UpdateAsync(User user, CancellationToken cancellationToken = default);
    Task DeleteAsync(Guid userId, CancellationToken cancellationToken = default);
}
