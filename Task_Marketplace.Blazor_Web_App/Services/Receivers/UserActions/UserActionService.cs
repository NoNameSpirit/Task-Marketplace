using Blazor_Web_App.Services.LocalStorage;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.UserActions;

namespace Blazor_Web_App.Services.Receivers.UserActions;

public class UserActionService(HttpClient _httpClient,
    ILocalStorageService _localStorage)
    : BaseService(_httpClient, _localStorage), IUserActionService
{
    public async Task<Result<PagedResult<UserActionDto>>> GetUserActionsAsync(
        Guid? userId,
        int? actionType,
        int page = FirstPageNumber,
        int pageSize = BasePageSize,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var url = $"?page={page}&pageSize={pageSize}";

        if (userId.HasValue)
        {
            url += $"&userId={userId.Value}";
        }

        if (actionType.HasValue)
        {
            url += $"&actionType={actionType.Value}";
        }

        var response = await _httpClient.GetAsync(url, cancellationToken);

        var result = await HandleResponseAsync<PagedResult<UserActionDto>>(
          response,
          cancellationToken);

        return result;
    }


}
