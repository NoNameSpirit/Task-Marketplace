using Microsoft.JSInterop;

namespace Blazor_Web_App.Services.LocalStorage;

public class LocalStorageService(
    IJSRuntime _jsRuntime) : ILocalStorageService
{
    private const string localStorageSetItem = "localStorage.setItem";
    private const string localStorageGetItem = "localStorage.getItem";
    private const string localStorageRemoveItem = "localStorage.removeItem";

    public async Task SetItemAsync(string key, string value)
    {
        await _jsRuntime.InvokeVoidAsync(localStorageSetItem, key, value);
    }

    public async Task<string?> GetItemAsync(string key)
    {
        var result = await _jsRuntime.InvokeAsync<string?>(localStorageGetItem, key);

        return result;
    }
    public async Task RemoveItemAsync(string key)
    {
        await _jsRuntime.InvokeVoidAsync(localStorageRemoveItem, key);
    }
}