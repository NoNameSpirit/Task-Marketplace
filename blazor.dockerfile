FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["Task_Marketplace.Blazor_Web_App/", "Task_Marketplace.Blazor_Web_App/"]
COPY ["Task_Marketplace.Shared/", "Task_Marketplace.Shared/"]
RUN dotnet restore "Task_Marketplace.Blazor_Web_App/Task_Marketplace.Blazor_Web_App.csproj"
WORKDIR "/src/Task_Marketplace.Blazor_Web_App"
RUN dotnet publish "Task_Marketplace.Blazor_Web_App.csproj" -c Release -o "/app/dlls"

FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR "/app"
COPY --from=build "/app/dlls" .
ENTRYPOINT ["dotnet", "Task_Marketplace.Blazor_Web_App.dll"]