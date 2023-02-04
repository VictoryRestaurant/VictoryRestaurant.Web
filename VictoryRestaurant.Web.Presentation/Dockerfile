FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["VictoryRestaurant.Web.Presentation/VictoryRestaurant.Web.Presentation.csproj", "VictoryRestaurant.Web.Presentation/"]
RUN dotnet restore "VictoryRestaurant.Web.Presentation/VictoryRestaurant.Web.Presentation.csproj"
COPY . .
WORKDIR "/src/VictoryRestaurant.Web.Presentation"
RUN dotnet build "VictoryRestaurant.Web.Presentation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VictoryRestaurant.Web.Presentation.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VictoryRestaurant.Web.Presentation.dll"]