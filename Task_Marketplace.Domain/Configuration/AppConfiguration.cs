namespace Domain.Configuration;

public class AppConfiguration
{
    public const string SectionName = nameof(AppConfiguration);

    public string AppName { get; set; } = "Task Marketplace";
    public string ConnectionString { get; set; } = string.Empty;
    public string Currency { get; set; } = "$";
}
