using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using Task_Marketplace.Shared.Dtos.Requests.Auth.Commands;

namespace Blazor_Web_App.Services.Receivers.Auth;

public interface IAuthService
{
    Task<Result<AuthDto>> RegisterAsync(RegisterRequest registerUserDto, CancellationToken cancellationToken = default);

    Task<Result<AuthDto>> LoginAsync(LoginRequest loginDto, CancellationToken cancellationToken = default);
}