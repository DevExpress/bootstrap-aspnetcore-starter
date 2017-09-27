FROM microsoft/aspnetcore-build:2.0.0 AS builder

ADD . /sources

WORKDIR /sources

RUN dotnet restore

RUN dotnet publish --output /app/ --configuration Release


FROM microsoft/aspnetcore:2.0.0

WORKDIR /app

COPY --from=builder /app .

COPY --from=builder /sources/Data Data

EXPOSE 5000

ENTRYPOINT ["dotnet", "bootstrap-starter.dll"]