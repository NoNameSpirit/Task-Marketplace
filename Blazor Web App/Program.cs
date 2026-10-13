using Blazor_Web_App.Components;
using Blazor_Web_App.Services;
using Blazor_Web_App.Services.Culture;
using Blazor_Web_App.Services.LocalStorage;
using Blazor_Web_App.Settings;
using Microsoft.AspNetCore.Components.Authorization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddLocalization();

builder.Services.AddAuthorizationCore()
                .AddCascadingAuthenticationState()
                .AddScoped<ILocalStorageService, LocalStorageService>()
                .AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>()
                .AddScoped<ICultureService, CultureService>();

builder.Services
    .AddOptions<ApiSettings>()
    .Bind(builder.Configuration.GetSection(ApiSettings.SectionName))
    .ValidateDataAnnotations()
    .ValidateOnStart();

var apiSettings = builder.Configuration
    .GetSection(ApiSettings.SectionName)
    .Get<ApiSettings>();

builder.Services.AddHttpClient<ApiService>(options =>
    {
        options.BaseAddress = new Uri(apiSettings!.ApiUrl);
    });


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
