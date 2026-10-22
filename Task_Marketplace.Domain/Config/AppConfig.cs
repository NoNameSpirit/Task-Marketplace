using System.ComponentModel.DataAnnotations;

namespace Domain.Config;

public class AppConfig : IConfigSection
{
    public static string SectionName { get; set; } = nameof(AppConfig);

    public string AppName { get; set; } = "Task Marketplace";
    [Required(ErrorMessage = "Connection string must be set to start an app")]
    public string ConnectionString { get; set; } = string.Empty;
    public string Currency { get; set; } = "$";
}
