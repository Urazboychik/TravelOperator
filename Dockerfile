FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY TravelOperator.csproj ./
RUN dotnet restore
COPY . ./
RUN dotnet publish TravelOperator.csproj -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
RUN useradd -m -u 1000 appuser
WORKDIR /home/appuser/app
ENV ASPNETCORE_ENVIRONMENT=Production
ENV ASPNETCORE_URLS=http://0.0.0.0:8080
EXPOSE 8080
COPY --from=build --chown=appuser:appuser /app/publish .
USER appuser
ENTRYPOINT ["dotnet", "TravelOperator.dll"]
