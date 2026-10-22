using Blazor_Web_App.Services.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Shared.Dtos.Responses.Users;
using System.Security.Claims;

namespace Blazor_Web_App.Services;

public class CustomAuthStateProvider(
    ILocalStorageService _localStorage) : AuthenticationStateProvider
{
    private const string AuthenticationType = "jwt";

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        try
        {
            var token = await _localStorage.GetItemAsync(nameof(AuthDto.Token));
            var name = await _localStorage.GetItemAsync(nameof(AuthDto.Name));
            var role = await _localStorage.GetItemAsync(nameof(AuthDto.Role));
            var id = await _localStorage.GetItemAsync(nameof(AuthDto.Id));

            if (!IsParamsNotEmpty(token, name, role, id))
            {
                return new AuthenticationState(
                    new ClaimsPrincipal(
                        new ClaimsIdentity()));
            }

            var identity = CreateClaimsIdentity(name!, role!, id!);

            return new AuthenticationState(new ClaimsPrincipal(identity));
        }
        catch
        {
            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
        }
    }

    public void NotifyLogin(
        string name,
        string role,
        string id)
    {
        var identity = CreateClaimsIdentity(name, role, id);

        NotifyWithIdentityOrDefault(identity);
    }

    public void NotifyLogout()
    {
        NotifyWithIdentityOrDefault();
    }

    private void NotifyWithIdentityOrDefault(ClaimsIdentity? identity = null)
    {
        if (identity is null)
        {
            identity = new ClaimsIdentity();
        }

        NotifyAuthenticationStateChanged(
            Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity))));
    }

    private ClaimsIdentity CreateClaimsIdentity(string name, string role, string userId)
    {
        var identity = new ClaimsIdentity(
        [
            new Claim(ClaimTypes.NameIdentifier, userId),
            new Claim(ClaimTypes.Name, name),
            new Claim(ClaimTypes.Role, role)
        ], AuthenticationType);

        return identity;
    }

    private bool IsParamsNotEmpty(params string?[] claims)
    {
        foreach (var claim in claims)
        {
            if (string.IsNullOrEmpty(claim))
            {
                return false;
            }
        }

        return true;
    }
}