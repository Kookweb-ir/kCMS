FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /src
COPY ["Kookweb.Presentation.Api/Kookweb.Presentation.Api.csproj", "Kookweb.Presentation.Api/"]
RUN dotnet restore "Kookweb.Presentation.Api/Kookweb.Presentation.Api.csproj"
COPY . .
WORKDIR "/src/Kookweb.Presentation.Api"
RUN dotnet build "Kookweb.Presentation.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Kookweb.Presentation.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Kookweb.Presentation.Api.dll"]
