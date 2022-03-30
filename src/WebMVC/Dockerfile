FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
RUN dotnet tool install --global dotnet-ef --version 6.0.3
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY ["src/WebMVC/WebMVC.csproj", "WebMVC/"]

RUN dotnet restore "src/WebMVC/WebMVC.csproj"
COPY . .
WORKDIR "/src/WebMVC"
RUN dotnet build "WebMVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebMVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebMVC.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet app-dev-mvc.dll
