using Blazor_Web_App.Services.LocalStorage;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using Shared.Enums;

namespace Blazor_Web_App.Services.Receivers.Users;

public class UserService(HttpClient _httpClient,
    ILocalStorageService _localStorage)
    : BaseService(_httpClient, _localStorage), IUserService
{
    public async Task<Result<PagedResult<UserDto>>> GetUsersAsync(
        int page = FirstPageNumber,
        int pageSize = BasePageSize,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"?page={page}&pageSize={pageSize}",
            cancellationToken);

        var result = await HandleResponseAsync<PagedResult<UserDto>>(
          response,
          cancellationToken);

        return result;
    }

    public async Task<Result> ChangeRoleAsync(
        Guid userId,
        UserRole newRole,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var body = new { NewRole = newRole };

        var response = await _httpClient.PatchAsJsonAsync(
            $"{userId}/role",
            body,
            cancellationToken);

        var result = await HandleResponseAsync(
           response,
           cancellationToken);

        return result;
    }

    public async Task<Result> BlockUserAsync(
        Guid userId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.PostAsync(
            $"{userId}/block",
            null,
            cancellationToken);

        var result = await HandleResponseAsync(
           response,
           cancellationToken);

        return result;
    }

    public async Task<Result> UnblockUserAsync(
        Guid userId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.PostAsync(
            $"{userId}/unblock",
            null,
            cancellationToken);

        var result = await HandleResponseAsync(
           response,
           cancellationToken);

        return result;
    }

    public async Task<Result> DeleteUserAsync(
        Guid userId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.DeleteAsync(
            $"{userId}",
            cancellationToken);

        var result = await HandleResponseAsync(
           response,
           cancellationToken);

        return result;
    }
}
