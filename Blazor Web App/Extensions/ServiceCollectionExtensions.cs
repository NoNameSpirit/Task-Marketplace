using Blazor_Web_App.Services;
using Blazor_Web_App.Services.Culture;
using Blazor_Web_App.Services.LocalStorage;
using Blazor_Web_App.Services.Receivers.Auth;
using Blazor_Web_App.Services.Receivers.Chats;
using Blazor_Web_App.Services.Receivers.ProjectTasks;
using Blazor_Web_App.Services.Receivers.TaskAttachments;
using Blazor_Web_App.Services.Receivers.UserActions;
using Blazor_Web_App.Services.Receivers.Users;
using Blazor_Web_App.Settings;
using Microsoft.AspNetCore.Components.Authorization;

namespace Blazor_Web_App.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection ConfigureHttpClients(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        var apiSettings = configuration
            .GetSection(ApiSettings.SectionName)
            .Get<ApiSettings>();

        services.AddHttpClient<IAuthService, AuthService>(client =>
            client.BaseAddress = new Uri($"{apiSettings!.ApiUrl}/api/auth/"));

        services.AddHttpClient<IProjectTaskService, ProjectTaskService>(client =>
            client.BaseAddress = new Uri($"{apiSettings!.ApiUrl}/api/projecttask/"));

        services.AddHttpClient<IChatService, ChatService>(client =>
            client.BaseAddress = new Uri($"{apiSettings!.ApiUrl}/api/chat/"));

        services.AddHttpClient<ITaskAttachmentService, TaskAttachmentService>(client =>
            client.BaseAddress = new Uri($"{apiSettings!.ApiUrl}/api/tasks/"));

        services.AddHttpClient<IUserActionService, UserActionService>(client =>
            client.BaseAddress = new Uri($"{apiSettings!.ApiUrl}/api/useraction/"));

        services.AddHttpClient<IUserService, UserService>(client =>
            client.BaseAddress = new Uri($"{apiSettings!.ApiUrl}/api/user/"));

        return services;
    }

    public static IServiceCollection ConfigureAppSettings(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services
            .AddOptions<ApiSettings>()
            .Bind(configuration.GetSection(ApiSettings.SectionName))
            .ValidateDataAnnotations()
            .ValidateOnStart();

        return services;
    }

    public static IServiceCollection AddServices(
        this IServiceCollection services)
    {
        services.AddScoped<ILocalStorageService, LocalStorageService>()
                .AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

        services.AddLocalization()
                .AddScoped<ICultureService, CultureService>();

        return services;
    }

    public static IServiceCollection AddAuth(
        this IServiceCollection services)
    {
        const string defaultString = "Identity.Application";

        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = defaultString;
            options.DefaultChallengeScheme = defaultString;
        })
        .AddCookie(defaultString, options =>
        {
            options.Events.OnRedirectToLogin = context =>
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;

                return Task.CompletedTask;
            };
        });

        services.AddAuthorizationCore()
                .AddCascadingAuthenticationState();

        return services;
    }
}
