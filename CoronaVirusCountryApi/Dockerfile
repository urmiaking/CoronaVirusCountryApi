FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["CoronaVirusCountryApi/CoronaVirusCountryApi.csproj", "CoronaVirusCountryApi/"]
RUN dotnet restore "CoronaVirusCountryApi/CoronaVirusCountryApi.csproj"
COPY . .
WORKDIR "/src/CoronaVirusCountryApi"
RUN dotnet build "CoronaVirusCountryApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CoronaVirusCountryApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CoronaVirusCountryApi.dll"]