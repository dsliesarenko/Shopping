FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Shopping.API.csproj", "./"]
RUN dotnet restore "Shopping.API.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet publish "Shopping.API.csproj" -c Release -o /app/publish -r linux-arm64 --self-contained false

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Shopping.API.dll"]
