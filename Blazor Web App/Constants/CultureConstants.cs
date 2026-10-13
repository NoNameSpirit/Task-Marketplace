namespace Blazor_Web_App.Constants;

public static class CultureConstants
{
    public const string English = "en-US";
    public const string Russian = "ru-RU";

    public const string Default = English;

    public const string StorageKey = "app.culture";

    public static readonly string[] Supported = { English, Russian };
}