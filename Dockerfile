FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY ConsoleApp/ConsoleApp.csproj .
RUN dotnet restore

COPY ConsoleApp/Program.cs .

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/runtime:8.0 AS runtime
WORKDIR /app

COPY --from=build /app/out .

#RUN dotnet add package Colorful.Console --version 1.2.16 --no-cache

CMD [ "dotnet", "ConsoleApp.dll"]
