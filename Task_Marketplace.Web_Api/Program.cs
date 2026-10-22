using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Web_Api.ExceptionHandler;
using Web_Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddControllers();

builder.Services.AddProblemDetails();
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();

var configuration = builder.Configuration;

builder.Services
    .AddConfigurationOptions(configuration)
    .AddApplicationServices()
    .AddInfrastructureServices(builder.Configuration)
    .AddJwtBearer(builder.Configuration)
    .AddSwagger();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    dbContext.Database.Migrate();
}

app.UseExceptionHandler();

if (app.Environment.IsDevelopment())
{
    app.MapSwagger();
    app.MapSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.MapGet("/", () => Results.Redirect("/swagger"));

app.Run();
