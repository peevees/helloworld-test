FROM mcr.microsoft.com/dotnet/core/runtime:2.2-stretch-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["helloworld/helloworld.csproj", "helloworld/"]
RUN dotnet restore "helloworld/helloworld.csproj"
COPY . .
WORKDIR "/src/helloworld"
RUN dotnet build "helloworld.csproj" -c Release -o /app