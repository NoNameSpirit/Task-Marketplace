using Microsoft.JSInterop;

namespace Blazor_Web_App.Services.LocalStorage;

public class LocalStorageService : ILocalStorageService
{
    private readonly IJSRuntime _jsRuntime;

    public LocalStorageService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async ValueTask SetItemAsync(string key, string value)
    {
        await _jsRuntime.InvokeVoidAsync("localStorage.setItem", key, value);
    }

    public async ValueTask<string?> GetItemAsync(string key)
    {
        var result = await _jsRuntime.InvokeAsync<string?>("localStorage.getItem", key);

        return result;
    }
    public async ValueTask RemoveItemAsync(string key)
    {
        await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", key);
    }
}