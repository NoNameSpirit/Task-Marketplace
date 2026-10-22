namespace Domain.Config;

public interface IConfigSection
{
    static abstract string SectionName { get; }
}
