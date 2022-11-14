#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["MinimalAPI-newOn7.0.cs/MinimalAPI-newOn7.0.cs.csproj", "MinimalAPI-newOn7.0.cs/"]
RUN dotnet restore "MinimalAPI-newOn7.0.cs/MinimalAPI-newOn7.0.cs.csproj"
COPY . .
WORKDIR "/src/MinimalAPI-newOn7.0.cs"
RUN dotnet build "MinimalAPI-newOn7.0.cs.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MinimalAPI-newOn7.0.cs.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MinimalAPI-newOn7.0.cs.dll"]