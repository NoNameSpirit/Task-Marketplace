namespace Domain.Config;

public class AppConfig
{
    public string SectionName { get; set; } = nameof(AppConfig);

    public string ConnectionString { get; set; } = string.Empty;
    public string Currency { get; set; } = "$";
}
