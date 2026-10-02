using Blazor_Web_App.Services.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Shared.Dtos.Responses.Users;
using System.Security.Claims;

namespace Blazor_Web_App.Services;

public class CustomAuthStateProvider : AuthenticationStateProvider
{
    private readonly ILocalStorageService _localStorage;

    public CustomAuthStateProvider(
        ILocalStorageService localStorage)
    {
        _localStorage = localStorage;
    }

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        try
        {
            var token = await _localStorage.GetItemAsync(nameof(AuthDto.Token));

            if (string.IsNullOrEmpty(token))
            {
                return new AuthenticationState(
                    new ClaimsPrincipal(
                        new ClaimsIdentity()));
            }

            var name = await _localStorage.GetItemAsync(nameof(AuthDto.Name));
            var role = await _localStorage.GetItemAsync(nameof(AuthDto.Role));
            var id = await _localStorage.GetItemAsync(nameof(AuthDto.Id));

            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.NameIdentifier, id!),
                new Claim(ClaimTypes.Name, name!),
                new Claim(ClaimTypes.Role, role!)
            }, "jwt");

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
        string userId)
    {
        var identity = new ClaimsIdentity(new[]
        {
            new Claim(ClaimTypes.NameIdentifier, userId),
            new Claim(ClaimTypes.Name, name),
            new Claim(ClaimTypes.Role, role)
        }, "jwt");

        NotifyAuthenticationStateChanged(
            Task.FromResult(
                new AuthenticationState(
                    new ClaimsPrincipal(identity))));
    }

    public void NotifyLogout()
    {
        NotifyAuthenticationStateChanged(
            Task.FromResult(
                new AuthenticationState(
                    new ClaimsPrincipal(
                        new ClaimsIdentity()))));
    }
}