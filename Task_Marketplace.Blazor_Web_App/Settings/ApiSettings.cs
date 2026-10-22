using System.ComponentModel.DataAnnotations;

namespace Blazor_Web_App.Settings;

public class ApiSettings
{
    public static string SectionName { get; set; } = nameof(ApiSettings);

    [Required(ErrorMessage = "Api Url must be setted before start up")]
    public string ApiUrl { get; set; } = string.Empty;
}
