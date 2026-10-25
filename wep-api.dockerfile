FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY ["Task_Marketplace.Web_Api/Task_Marketplace.Web_Api.csproj", "Task_Marketplace.Web_Api/"]
COPY ["Task_Marketplace.Application/Task_Marketplace.Application.csproj", "Task_Marketplace.Application/"]
COPY ["Task_Marketplace.Domain/Task_Marketplace.Domain.csproj", "Task_Marketplace.Domain/"]
COPY ["Task_Marketplace.Infrastructure/Task_Marketplace.Infrastructure.csproj", "Task_Marketplace.Infrastructure/"]
COPY ["Task_Marketplace.Shared/Task_Marketplace.Shared.csproj", "Task_Marketplace.Shared/"]

COPY ["Task_Marketplace.Web_Api/", "Task_Marketplace.Web_Api/"]
COPY ["Task_Marketplace.Application/", "Task_Marketplace.Application/"]
COPY ["Task_Marketplace.Domain/", "Task_Marketplace.Domain/"]
COPY ["Task_Marketplace.Infrastructure/", "Task_Marketplace.Infrastructure/"]
COPY ["Task_Marketplace.Shared/", "Task_Marketplace.Shared/"]

RUN dotnet restore "Task_Marketplace.Web_Api/Task_Marketplace.Web_Api.csproj"

WORKDIR "/src/Task_Marketplace.Web_Api"
RUN dotnet publish "Task_Marketplace.Web_Api.csproj" -c Release -o "/app/dlls"

FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR "/app"
COPY --from=build "/app/dlls" .
ENTRYPOINT ["dotnet", "Task_Marketplace.Web_Api.dll"]