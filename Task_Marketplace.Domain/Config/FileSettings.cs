using System.ComponentModel.DataAnnotations;

namespace Domain.Config;

public class FileSettings : IConfigSection
{
    public static string SectionName { get; set; } = nameof(FileSettings);


    [Required(ErrorMessage = "File name must be set to start an app")]
    public string FileName { get; set; } = string.Empty;
    public string FullPath { get; set; } = string.Empty;
}
