using System.ComponentModel.DataAnnotations;

namespace Domain.Config;

public class JwtSettings : IConfigSection
{
    public static string SectionName { get; set; } = nameof(JwtSettings);

    [Required(ErrorMessage = "Key must be set to start an app")]
    public string Key { get; set; } = string.Empty;
    [Required(ErrorMessage = "Valid issuer must be set to start an app")]
    public string[] ValidIssuers { get; set; } = [];
    [Required(ErrorMessage = "Valid audience must be set to start an app")]
    public string[] ValidAudiences { get; set; } = [];
}
