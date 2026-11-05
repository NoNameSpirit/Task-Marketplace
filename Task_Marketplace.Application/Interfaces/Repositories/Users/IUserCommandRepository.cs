using Domain.Entities;

namespace Task_Marketplace.Application.Interfaces.Repositories.Users;

public interface IUserCommandRepository
{
    Task AddAsync(User user, CancellationToken cancellationToken = default);
    Task UpdateAsync(User user, CancellationToken cancellationToken = default);
    Task DeleteAsync(Guid userId, CancellationToken cancellationToken = default);
}
