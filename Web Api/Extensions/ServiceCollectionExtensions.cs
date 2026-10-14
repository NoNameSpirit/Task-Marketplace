using Application.Common;
using Application.ProjectTasks.Commands.Create;
using Application.Services.FileStorage;
using Application.Services.Hasher;
using Application.Services.JwtGenerator;
using Domain.Config;
using Domain.Interfaces.Chats;
using Domain.Interfaces.Files;
using Domain.Interfaces.ProjectTasks;
using Domain.Interfaces.UserActions;
using Domain.Interfaces.Users;
using Infrastructure;
using Infrastructure.Repositories.Chats;
using Infrastructure.Repositories.ProjectTasks;
using Infrastructure.Repositories.UserActions;
using Infrastructure.Repositories.Users;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using System.Text;
using Web_Api.Extensions.Constants;

namespace Web_Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSwagger(
        this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc(SwaggerConstants.VersionName, new OpenApiInfo
            {
                Title = SwaggerConstants.Title,
                Version = SwaggerConstants.VersionName
            });

            options.AddSecurityDefinition(SwaggerConstants.SchemeName, new OpenApiSecurityScheme
            {
                Name = SwaggerConstants.SecuritySchemeName,
                Type = SecuritySchemeType.Http,
                Scheme = SwaggerConstants.SecurityScheme,
                BearerFormat = SwaggerConstants.SecurityBearerFormat,
                In = ParameterLocation.Header,
                Description = SwaggerConstants.SecurityDescription
            });

            options.AddSecurityRequirement(document =>
                new OpenApiSecurityRequirement
                {
                    [new OpenApiSecuritySchemeReference(SwaggerConstants.SchemeName, document)] = []
                });
        });

        return services;
    }

    public static IServiceCollection AddConfigurationOptions(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services
            .AddOptions<AppConfig>()
            .Bind(configuration.GetSection(AppConfig.SectionName))
            .ValidateDataAnnotations()
            .ValidateOnStart();

        services
            .AddOptions<JwtSettings>()
            .Bind(configuration.GetSection(JwtSettings.SectionName))
            .ValidateDataAnnotations()
            .ValidateOnStart();

        services
            .AddOptions<FileSettings>()
            .Bind(configuration.GetSection(FileSettings.SectionName))
            .Configure(options =>
            {
                var userRoaming = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

                var appConfig = configuration.GetSection(AppConfig.SectionName)
                    .Get<AppConfig>();

                options.FullPath = Path.Combine(
                    userRoaming,
                    appConfig!.AppName,
                    options.FileName);
            })
            .ValidateDataAnnotations()
            .ValidateOnStart();

        return services;
    }

    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IUserActionCommandRepository, UserActionCommandRepository>()
                .AddTransient(typeof(IPipelineBehavior<,>), typeof(UserActionLoggingBehavior<,>));

        services.AddMediatR(configuration =>
            configuration.RegisterServicesFromAssembly(typeof(CreateProjectTaskCommand).Assembly));

        services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>()
                .AddScoped<IPasswordHasher, PasswordHasher>()
                .AddScoped<IFileStorageService, FileStorageService>();

        return services;
    }
    public static IServiceCollection AddInfrastructureServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>((serviceProvider, options) =>
        {
            var appConfig = serviceProvider.GetRequiredService<IOptions<AppConfig>>().Value;

            options.UseSqlServer(appConfig.ConnectionString);
        });

        services.AddScoped<IChatCommandRepository, ChatCommandRepository>()
                .AddScoped<IChatQueryRepository, ChatQueryRepository>();

        services.AddScoped<IProjectTaskCommandRepository, ProjectTaskCommandRepository>()
                .AddScoped<IProjectTaskQueryRepository, ProjectTaskQueryRepository>();

        services.AddScoped<IUserCommandRepository, UserCommandRepository>()
                .AddScoped<IUserQueryRepository, UserQueryRepository>();

        services.AddScoped<IUserActionCommandRepository, UserActionCommandRepository>()
                .AddScoped<IUserActionQueryRepository, UserActionQueryRepository>();

        services.AddScoped<ITaskAttachmentCommandRepository, TaskAttachmentCommandRepository>()
                .AddScoped<ITaskAttachmentQueryRepository, TaskAttachmentQueryRepository>();

        return services;
    }

    public static IServiceCollection AddJwtBearer(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        var jwtSettings = configuration.GetSection(JwtSettings.SectionName)
            .Get<JwtSettings>();

        services.AddAuthentication()
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings!.Key)),
                    ValidAudiences = jwtSettings.ValidAudiences,
                    ValidIssuers = jwtSettings.ValidIssuers,
                };
            });

        return services;
    }
}
