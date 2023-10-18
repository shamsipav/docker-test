FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DockerWebApplication/DockerWebApplication.csproj", "DockerWebApplication/"]
RUN dotnet restore "DockerWebApplication/DockerWebApplication.csproj"
COPY . .
WORKDIR "/src/DockerWebApplication"
RUN dotnet build "DockerWebApplication.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DockerWebApplication.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DockerWebApplication.dll"]