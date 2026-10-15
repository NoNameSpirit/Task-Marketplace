namespace Blazor_Web_App.Services.LocalStorage;

public interface ILocalStorageService
{
    Task SetItemAsync(string key, string value);

    Task<string?> GetItemAsync(string key);

    Task RemoveItemAsync(string key);
}
