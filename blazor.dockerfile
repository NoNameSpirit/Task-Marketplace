FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["Blazor Web App/", "Blazor Web App/"]
COPY ["Shared/", "Shared/"]
RUN dotnet restore "Blazor Web App/Blazor Web App.csproj"
WORKDIR "/src/Blazor Web App"
RUN dotnet publish "Blazor Web App.csproj" -c Release -o "/app/dlls"

FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR "/app"
COPY --from=build "/app/dlls" .
ENTRYPOINT ["dotnet", "Blazor_Web_App.dll"]