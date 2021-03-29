#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ddns/ddns.csproj", "ddns/"]
RUN dotnet restore "ddns/ddns.csproj"
COPY . .
WORKDIR "/src/ddns"
RUN dotnet build "ddns.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ddns.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ddns.dll"]