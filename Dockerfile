FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./Is2Plus2Equal2/*.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY ./Is2Plus2Equal2/* ./
RUN dotnet publish -c Release -o out Is2Plus2Equal4.csproj

ENTRYPOINT ["dotnet", "./out/Is2Plus2Equal4.dll"] 
