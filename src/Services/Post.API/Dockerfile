#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Services/Post.API/Post.API.csproj", "Services/Post.API/"]
RUN dotnet restore "Services/Post.API/Post.API.csproj"
COPY . .
WORKDIR "/src/Services/Post.API"
RUN dotnet build "Post.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Post.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Post.API.dll"]