FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 51829
EXPOSE 44303

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY Femi.MW.REST/Femi.MW.REST.csproj Femi.MW.REST/
RUN dotnet restore Femi.MW.REST/Femi.MW.REST.csproj
COPY . .
WORKDIR /src/Femi.MW.REST
RUN dotnet build Femi.MW.REST.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Femi.MW.REST.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Femi.MW.REST.dll"]
