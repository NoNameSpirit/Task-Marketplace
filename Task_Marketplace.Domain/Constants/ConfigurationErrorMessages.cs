namespace Task_Marketplace.Domain.Constants;

public static class ConfigurationErrorMessages
{
    public const string ConnectionStringRequired = "AppConfig:ConnectionString is required to start the application";
    public const string AppNameRequired = "AppConfig:AppName is required to start the application";
    public const string JwtKeyRequired = "JwtSettings:Key is required to start the application";
    public const string JwtKeyTooShort = "JwtSettings:Key must be at least {0} characters long";
    public const string ValidIssuersRequired = "JwtSettings:ValidIssuers must contain at least one issuer";
    public const string ValidAudiencesRequired = "JwtSettings:ValidAudiences must contain at least one audience";
    public const string ExpiresHoursMustBePositive = "JwtSettings:ExpiresHours must be greater than zero";
    public const string FileNameRequired = "FileSettings:FileName is required to start the application";
    public const string ValidationFailedHeader = "Invalid configuration:";
    public const string ErrorLinePrefix = " - ";
}