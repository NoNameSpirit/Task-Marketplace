using Blazor_Web_App.Constants;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using Shared.Enums;

namespace Blazor_Web_App.Services.Receivers.Users;

public interface IUserService
{
    Task<Result<PagedResult<UserDto>>> GetUsersAsync(int page = Pagination.FirstPage, int pageSize = Pagination.DefaultPageSize, CancellationToken cancellationToken = default);

    Task<Result> ChangeRoleAsync(Guid userId, UserRole newRole, CancellationToken cancellationToken = default);

    Task<Result> BlockUserAsync(Guid userId, CancellationToken cancellationToken = default);

    Task<Result> UnblockUserAsync(Guid userId, CancellationToken cancellationToken = default);

    Task<Result> DeleteUserAsync(Guid userId, CancellationToken cancellationToken = default);
}