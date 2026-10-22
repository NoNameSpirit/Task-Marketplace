namespace Blazor_Web_App.Services.Culture;

public interface ICultureService
{
    Task<string> GetCultureAsync();

    Task SetCultureAsync(string culture);

    void Apply(string culture);
}
