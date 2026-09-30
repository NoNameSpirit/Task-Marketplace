FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY ["Web Api/Web Api.csproj", "Web Api/"]
COPY ["Application/Application.csproj", "Application/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Infrastructure/Infrastructure.csproj", "Infrastructure/"]
COPY ["Shared/Shared.csproj", "Shared/"]

COPY ["Web Api/", "Web Api/"]
COPY ["Application/", "Application/"]
COPY ["Domain/", "Domain/"]
COPY ["Infrastructure/", "Infrastructure/"]
COPY ["Shared/", "Shared/"]

RUN dotnet restore "Web Api/Web Api.csproj"

WORKDIR "/src/Web Api"
RUN dotnet publish "Web Api.csproj" -c Release -o "/app/dlls"

FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR "/app"
COPY --from=build "/app/dlls" .
ENTRYPOINT ["dotnet", "Web Api.dll"]