# Base image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Shopping.Client.csproj", "./"]
RUN dotnet restore "Shopping.Client.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet publish "Shopping.Client.csproj" -c Release -o /app/publish -r linux-arm64 --self-contained false

# Final stage
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Shopping.Client.dll"]
