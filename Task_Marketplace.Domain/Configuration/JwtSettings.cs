namespace Domain.Configuration;

public class JwtSettings
{
    public static string SectionName { get; set; } = nameof(JwtSettings);
    public const int MinKeyLength = 32;

    public string Key { get; set; } = string.Empty;
    public string[] ValidIssuers { get; set; } = [];
    public string[] ValidAudiences { get; set; } = [];
    public int ExpiresHours { get; set; } = 2;
}
