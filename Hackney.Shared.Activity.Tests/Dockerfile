FROM mcr.microsoft.com/dotnet/core/sdk:3.1

# disable microsoft telematry
ENV DOTNET_CLI_TELEMETRY_OPTOUT='true'

ARG LBHPACKAGESTOKEN
ENV LBHPACKAGESTOKEN=$LBHPACKAGESTOKEN
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./Hackney.Shared.Activity.sln ./
COPY ./Hackney.Shared.Activity/Hackney.Shared.Activity.csproj ./Hackney.Shared.Activity/
COPY ./Hackney.Shared.Activity.Tests/Hackney.Shared.Activity.Tests.csproj ./Hackney.Shared.Activity.Tests/
COPY /nuget.config /root/.nuget/NuGet/NuGet.Config

RUN dotnet restore ./Hackney.Shared.Activity/Hackney.Shared.Activity.csproj
RUN dotnet restore ./Hackney.Shared.Activity.Tests/Hackney.Shared.Activity.Tests.csproj

# Copy everything else and build
COPY . .

RUN dotnet build -c debug -o out Hackney.Shared.Activity.Tests/Hackney.Shared.Activity.Tests.csproj

CMD dotnet test
