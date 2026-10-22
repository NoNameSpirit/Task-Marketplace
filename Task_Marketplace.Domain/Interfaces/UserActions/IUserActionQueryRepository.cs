using Domain.Entities;
using Shared.Dtos.Responses;

namespace Domain.Interfaces.UserActions;

public interface IUserActionQueryRepository
{
    Task<PagedResult<UserAction>> GetAsync(
        Guid? userId,
        int? actionType,
        int page,
        int pageSize,
        CancellationToken cancellationToken = default);
}