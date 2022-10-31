FROM mcr.microsoft.com/dotnet/sdk:7.0
RUN apt update

COPY . /app
WORKDIR /app
