using Application.ProjectTasks.Commands.Create;
using Application.Services.Hasher;
using Application.Services.JwtGenerator;
using Domain.Config;
using Domain.Interfaces.Chats;
using Domain.Interfaces.ProjectTasks;
using Domain.Interfaces.Users;
using Infrastructure;
using Infrastructure.Repositories.Chats;
using Infrastructure.Repositories.ProjectTasks;
using Infrastructure.Repositories.Users;
using Infrastructure.Workers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using System.Text;

namespace Web_Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSwagger(
        this IServiceCollection services)
    {
        services.AddSwaggerGen(option =>
        {
            var openApiInfo = new OpenApiInfo
            {
                Title = "Demo API",
                Version = "v1"
            };

            option.SwaggerDoc("v1", openApiInfo);

            option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                In = ParameterLocation.Header,
                Description = "JWT Authorization header using the Bearer scheme.",
                Name = "Authorization",
                Type = SecuritySchemeType.Http,
                BearerFormat = "JWT",
                Scheme = "Bearer"
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

        return services;
    }

    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
            configuration.RegisterServicesFromAssembly(typeof(CreateProjectTaskCommand).Assembly));

        services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>()
                .AddScoped<IPasswordHasher, PasswordHasher>();

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

        services.AddHostedService<DeadlineOverdueWorker>();

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
