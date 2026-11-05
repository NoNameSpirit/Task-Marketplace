using Domain.Configuration;
using Infrastructure;
using Infrastructure.Repositories;
using Infrastructure.Repositories.Chats;
using Infrastructure.Repositories.Files;
using Infrastructure.Repositories.ProjectTasks;
using Infrastructure.Repositories.UserActions;
using Infrastructure.Repositories.Users;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using System.Text;
using Task_Marketplace.Application.Behaviors;
using Task_Marketplace.Application.Handlers.ProjectTasks.Commands.Create;
using Task_Marketplace.Application.Interfaces;
using Task_Marketplace.Application.Interfaces.Cache;
using Task_Marketplace.Application.Interfaces.Repositories.Chats;
using Task_Marketplace.Application.Interfaces.Repositories.Files;
using Task_Marketplace.Application.Interfaces.Repositories.ProjectTasks;
using Task_Marketplace.Application.Interfaces.Repositories.UserActions;
using Task_Marketplace.Application.Interfaces.Repositories.Users;
using Task_Marketplace.Domain.Configuration;
using Task_Marketplace.Domain.Constants;
using Task_Marketplace.Infrastructure.Cache;
using Task_Marketplace.Infrastructure.Constants;
using Task_Marketplace.Infrastructure.FileStorage;
using Task_Marketplace.Infrastructure.Services.Hasher;
using Task_Marketplace.Infrastructure.Services.JwtGenerator;
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
        var app = configuration
            .GetSection(AppConfiguration.SectionName)
            .Get<AppConfiguration>() ?? new AppConfiguration();

        var jwt = configuration
            .GetSection(JwtSettings.SectionName)
            .Get<JwtSettings>() ?? new JwtSettings();

        var file = configuration
            .GetSection(FileSettings.SectionName)
            .Get<FileSettings>() ?? new FileSettings();

        if (string.IsNullOrWhiteSpace(file.FullPath))
        {
            var userRoaming = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            file.FullPath = Path.Combine(userRoaming, app.AppName, file.FileName);
        }

        var errors = ConfigurationValidator.Validate(app, jwt, file);
        if (errors.Count > 0)
        {
            var message = new StringBuilder();
            message.AppendLine(ConfigurationErrorMessages.ValidationFailedHeader);

            foreach (var error in errors)
            {
                message.AppendLine(ConfigurationErrorMessages.ErrorLinePrefix + error);
            }

            throw new InvalidOperationException(message.ToString());
        }

        services.AddSingleton(app);
        services.AddSingleton(jwt);
        services.AddSingleton(file);

        return services;
    }

    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddHttpContextAccessor();

        services.AddScoped<ICurrentUser, CurrentUser>();

        services.AddScoped<IUserActionCommandRepository, UserActionCommandRepository>();
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CacheInvalidationBehaviour<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(TransactionBehaviour<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UserActionLoggingBehavior<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CachingBehaviour<,>));

        services.AddMediatR(configuration =>
            configuration.RegisterServicesFromAssembly(typeof(CreateProjectTaskCommand).Assembly));

        services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddScoped<IPasswordHasher, PasswordHasher>();

        return services;
    }
    public static IServiceCollection AddInfrastructureServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>((serviceProvider, options) =>
        {
            var appConfig = serviceProvider.GetRequiredService<AppConfiguration>();

            options.UseSqlServer(appConfig.ConnectionString);
        });

        services.AddScoped<IChatCommandRepository, ChatCommandRepository>();
        services.AddScoped<IChatQueryRepository, ChatQueryRepository>();

        services.AddScoped<IProjectTaskCommandRepository, ProjectTaskCommandRepository>();
        services.AddScoped<IProjectTaskQueryRepository, ProjectTaskQueryRepository>();

        services.AddScoped<IUserCommandRepository, UserCommandRepository>();
        services.AddScoped<IUserQueryRepository, UserQueryRepository>();

        services.AddScoped<IUserActionQueryRepository, UserActionQueryRepository>();

        services.AddScoped<ITaskAttachmentCommandRepository, TaskAttachmentCommandRepository>();
        services.AddScoped<ITaskAttachmentQueryRepository, TaskAttachmentQueryRepository>();

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddStackExchangeRedisCache(options =>
        {
            options.Configuration = configuration.GetConnectionString(RedisCacheConstants.ConnectionStringName);
            options.InstanceName = RedisCacheConstants.InstanceName;
        });

        services.AddScoped<ICacheService, CacheService>()
                .AddScoped<IFileStorageService, FileStorageService>();

        return services;
    }

    public static IServiceCollection AddJwtAuthentication(this IServiceCollection services)
    {
        services.AddAuthentication().AddJwtBearer();

        services
            .AddOptions<JwtBearerOptions>(JwtBearerDefaults.AuthenticationScheme)
            .Configure<JwtSettings>((options, jwtSettings) =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Key)),
                    ValidAudiences = jwtSettings.ValidAudiences,
                    ValidIssuers = jwtSettings.ValidIssuers,
                };
            });

        return services;
    }
}