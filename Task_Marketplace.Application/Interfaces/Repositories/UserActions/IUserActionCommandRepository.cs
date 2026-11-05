using Domain.Entities;

namespace Task_Marketplace.Application.Interfaces.Repositories.UserActions;

public interface IUserActionCommandRepository
{
    Task AddAsync(UserAction action, CancellationToken cancellationToken = default);
}
