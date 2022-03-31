FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WebMVC/WebMVC.csproj", "WebMVC/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Infrastructure/Infrastructure.csproj", "Infrastructure/"]
RUN dotnet restore "WebMVC/WebMVC.csproj"
COPY . .
WORKDIR "WebMVC"
RUN dotnet build "WebMVC.csproj" -c Release -o /app/build 

FROM build AS publish
RUN dotnet publish "WebMVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebMVC.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet app-dev-mvc.dll