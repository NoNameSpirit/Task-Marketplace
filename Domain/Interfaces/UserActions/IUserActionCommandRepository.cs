using Domain.Entities;

namespace Domain.Interfaces.UserActions;

public interface IUserActionCommandRepository
{
    Task AddAsync(UserAction action, CancellationToken cancellationToken = default);
}
