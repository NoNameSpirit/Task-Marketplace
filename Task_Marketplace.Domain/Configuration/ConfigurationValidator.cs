using Domain.Configuration;
using Task_Marketplace.Domain.Constants;

namespace Task_Marketplace.Domain.Configuration;

public static class ConfigurationValidator
{
    public static IReadOnlyList<string> Validate(
        AppConfiguration app,
        JwtSettings jwt,
        FileSettings file)
    {
        var errors = new List<string>();

        if (string.IsNullOrWhiteSpace(app.ConnectionString))
        {
            errors.Add(ConfigurationErrorMessages.ConnectionStringRequired);
        }

        if (string.IsNullOrWhiteSpace(app.AppName))
        {
            errors.Add(ConfigurationErrorMessages.AppNameRequired);
        }

        if (string.IsNullOrWhiteSpace(jwt.Key))
        {
            errors.Add(ConfigurationErrorMessages.JwtKeyRequired);
        }
        else if (jwt.Key.Length < JwtSettings.MinKeyLength)
        {
            errors.Add(string.Format(
                ConfigurationErrorMessages.JwtKeyTooShort,
                JwtSettings.MinKeyLength));
        }

        if (jwt.ValidIssuers.Length == 0)
        {
            errors.Add(ConfigurationErrorMessages.ValidIssuersRequired);
        }

        if (jwt.ValidAudiences.Length == 0)
        {
            errors.Add(ConfigurationErrorMessages.ValidAudiencesRequired);
        }

        if (jwt.ExpiresHours <= 0)
        {
            errors.Add(ConfigurationErrorMessages.ExpiresHoursMustBePositive);
        }

        if (string.IsNullOrWhiteSpace(file.FileName))
        {
            errors.Add(ConfigurationErrorMessages.FileNameRequired);
        }

        return errors;
    }
}
