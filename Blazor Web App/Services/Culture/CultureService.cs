using Blazor_Web_App.Constants;
using Blazor_Web_App.Services.Culture;
using Blazor_Web_App.Services.LocalStorage;
using System.Globalization;

namespace Blazor_Web_App.Services;

public class CultureService : ICultureService
{
    private readonly ILocalStorageService _storage;

    public CultureService(ILocalStorageService storage)
    {
        _storage = storage;
    }

    public async Task<string> GetCultureAsync()
    {
        var value = await _storage.GetItemAsync(CultureConstants.StorageKey);

        return string.IsNullOrWhiteSpace(value)
            ? CultureConstants.Default
            : value;
    }

    public async Task SetCultureAsync(string culture)
    {
        if (!CultureConstants.Supported.Contains(culture))
        {
            culture = CultureConstants.Default;
        }

        await _storage.SetItemAsync(CultureConstants.StorageKey, culture);
    }

    public void Apply(string culture)
    {
        var cultureInfo = new CultureInfo(culture);

        CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
        CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
    }
}