#FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443

#FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
#WORKDIR /src
#COPY ["guardi/guardi.csproj", "guardi/"]
#RUN dotnet restore "guardi/guardi.csproj"
#COPY . .
#WORKDIR "/src/guardi"
#RUN dotnet build "guardi.csproj" -c Release -o /app/build

#FROM build AS publish
#RUN dotnet publish "guardi.csproj" -c Release -o /app/publish

#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "guardi.dll"]


  # syntax=docker/dockerfile:1
  FROM mcr.microsoft.com/dotnet/aspnet:5.0
  COPY bin/Release/netcoreapp3.1/publish/ App/
  WORKDIR /App
  ENTRYPOINT ["dotnet", "guardi.dll"]