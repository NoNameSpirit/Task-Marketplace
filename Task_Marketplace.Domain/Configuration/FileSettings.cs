namespace Domain.Configuration;

public class FileSettings
{
    public static string SectionName { get; set; } = nameof(FileSettings);

    public string FileName { get; set; } = string.Empty;
    public string FullPath { get; set; } = string.Empty;
}
