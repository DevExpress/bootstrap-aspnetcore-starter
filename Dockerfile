FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /app

COPY . ./aspnetapp/
WORKDIR /app/aspnetapp
RUN dotnet restore bootstrap-starter.csproj
RUN dotnet publish bootstrap-starter.csproj -c Release -o out


FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime
WORKDIR /app
COPY --from=build /app/aspnetapp/out ./
ENTRYPOINT ["dotnet", "bootstrap-starter.dll"]