using Shared.Dtos.Requests.Users;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;

namespace Blazor_Web_App.Services.Receivers.Auth;

public interface IAuthService
{
    Task<Result<AuthDto>> RegisterAsync(RegisterUserDto registerUserDto, CancellationToken cancellationToken = default);

    Task<Result<AuthDto>> LoginAsync(LoginDto loginDto, CancellationToken cancellationToken = default);
}