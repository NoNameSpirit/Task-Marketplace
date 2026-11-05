using Blazor_Web_App.Services.LocalStorage;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using Task_Marketplace.Shared.Dtos.Requests.Auth.Commands;

namespace Blazor_Web_App.Services.Receivers.Auth;

public class AuthService(
    HttpClient _httpClient,
    ILocalStorageService _localStorage)
    : BaseService(_httpClient, _localStorage), IAuthService
{
    public async Task<Result<AuthDto>> RegisterAsync(
        RegisterRequest registerUserDto,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.PostAsJsonAsync(
            "register",
            registerUserDto,
            cancellationToken);

        var result = await HandleResponseAsync<AuthDto>(response, cancellationToken);

        return result;
    }

    public async Task<Result<AuthDto>> LoginAsync(
        LoginRequest loginDto,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.PostAsJsonAsync(
            "login",
            loginDto,
            cancellationToken);

        var result = await HandleResponseAsync<AuthDto>(response, cancellationToken);

        return result;
    }
}
