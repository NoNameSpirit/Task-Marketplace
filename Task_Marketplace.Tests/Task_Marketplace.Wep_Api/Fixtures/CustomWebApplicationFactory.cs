using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Task_Marketplace.Tests.Integration.Infrastructure;

public class CustomWebApplicationFactory(string connectionString)
    : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.UseEnvironment("Development");
        builder.UseSetting("ASPNETCORE_ENVIRONMENT", "Development");

        builder.UseSetting("AppConfiguration:ConnectionString", connectionString);
        builder.UseSetting("AppConfiguration:AppName", "Task Marketplace");
        builder.UseSetting("AppConfiguration:Currency", "$");

        builder.UseSetting("JwtSettings:Key", TestConstants.JwtKey);
        builder.UseSetting("JwtSettings:ValidIssuers:0", TestConstants.Issuer);
        builder.UseSetting("JwtSettings:ValidAudiences:0", TestConstants.Audience);
        builder.UseSetting("JwtSettings:ExpiresHours", "2");

        builder.UseSetting("FileSettings:FileName", "IntegrationTestsFiles");
        builder.UseSetting("ConnectionStrings:Redis", "localhost:6379");

        builder.ConfigureServices(services =>
        {
            services.RemoveAll<IDistributedCache>();
            services.AddDistributedMemoryCache();
        });
    }
}