using Blazor_Web_App.Constants;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.UserActions;

namespace Blazor_Web_App.Services.Receivers.UserActions;

public interface IUserActionService
{
    Task<Result<PagedResult<UserActionDto>>> GetUserActionsAsync(Guid? userId, int? actionType, int page = Pagination.FirstPage, int pageSize = Pagination.DefaultPageSize, CancellationToken cancellationToken = default);
}