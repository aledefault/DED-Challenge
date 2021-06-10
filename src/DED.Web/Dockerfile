#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/DED.Web/DED.Web.csproj", "src/DED.Web/"]
RUN dotnet restore "src/DED.Web/DED.Web.csproj"
COPY . .
WORKDIR "/src/src/DED.Web"
RUN dotnet build "DED.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DED.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DED.Web.dll"]