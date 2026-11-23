# ---------- build stage ----------
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Restore first so the package layer is cached between builds
COPY API/API.csproj API/
RUN dotnet restore API/API.csproj

COPY API/ API/
RUN dotnet publish API/API.csproj -c Release -o /app/publish --no-restore /p:UseAppHost=false

# ---------- runtime stage ----------
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app

ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

COPY --from=build /app/publish .

# The app user must own /app so the CSV import can create Student-Password.csv
RUN chown -R $APP_UID /app

# Run as the non-root user that ships with the .NET images
USER $APP_UID

# Apply pending EF Core migrations first, then start the API
ENTRYPOINT ["sh", "-c", "dotnet API.dll --migrate && exec dotnet API.dll"]
