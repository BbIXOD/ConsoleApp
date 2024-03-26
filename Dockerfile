FROM mcr.microsoft.com/dotnet/sdk:8.0
WORKDIR /app

COPY /ConsoleApp .

RUN dotnet restore
RUN dotnet publish -c Release -o out

CMD [ "dotnet", "out/ConsoleApp.dll"]