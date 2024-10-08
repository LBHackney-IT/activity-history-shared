FROM mcr.microsoft.com/dotnet/core/sdk:3.1

# disable microsoft telematry
ENV DOTNET_CLI_TELEMETRY_OPTOUT='true'

WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./Hackney.Shared.ActivityHistory.sln ./
COPY ./Hackney.Shared.ActivityHistory/Hackney.Shared.ActivityHistory.csproj ./Hackney.Shared.ActivityHistory/
COPY ./Hackney.Shared.ActivityHistory.Tests/Hackney.Shared.ActivityHistory.Tests.csproj ./Hackney.Shared.ActivityHistory.Tests/
COPY /nuget.config /root/.nuget/NuGet/NuGet.Config

# We mount secrets so they can't end up in logs or build layers.
# We chain both restore commands so we only make the token available
# once and don't store it elsewhere.
# see:
#   - https://docs.docker.com/reference/dockerfile/#arg
#   - https://docs.docker.com/compose/how-tos/use-secrets/
RUN --mount=type=secret,id=LBHPACKAGESTOKEN \
  export LBHPACKAGESTOKEN=$(cat /run/secrets/LBHPACKAGESTOKEN) && \
  dotnet restore ./Hackney.Shared.ActivityHistory/Hackney.Shared.ActivityHistory.csproj && \
  dotnet restore ./Hackney.Shared.ActivityHistory.Tests/Hackney.Shared.ActivityHistory.Tests.csproj

# Copy everything else and build
COPY . .

RUN dotnet build -c debug -o out Hackney.Shared.ActivityHistory.Tests/Hackney.Shared.ActivityHistory.Tests.csproj

CMD dotnet test
