FROM mcr.microsoft.com/dotnet/core/sdk:3.1

# disable microsoft telematry
ENV DOTNET_CLI_TELEMETRY_OPTOUT='true'

ARG LBHPACKAGESTOKEN
ENV LBHPACKAGESTOKEN=$LBHPACKAGESTOKEN
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./Hackney.Shared.ActivityHistory.sln ./
COPY ./Hackney.Shared.ActivityHistory/Hackney.Shared.ActivityHistory.csproj ./Hackney.Shared.ActivityHistory/
COPY ./Hackney.Shared.ActivityHistory.Tests/Hackney.Shared.ActivityHistory.Tests.csproj ./Hackney.Shared.ActivityHistory.Tests/
COPY /nuget.config /root/.nuget/NuGet/NuGet.Config

RUN dotnet restore ./Hackney.Shared.ActivityHistory/Hackney.Shared.ActivityHistory.csproj
RUN dotnet restore ./Hackney.Shared.ActivityHistory.Tests/Hackney.Shared.ActivityHistory.Tests.csproj

# Copy everything else and build
COPY . .

RUN dotnet build -c debug -o out Hackney.Shared.ActivityHistory.Tests/Hackney.Shared.ActivityHistory.Tests.csproj

CMD dotnet test
