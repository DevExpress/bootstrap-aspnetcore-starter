FROM microsoft/aspnetcore-build:2.0.0 AS builder

ADD DevExpress.AspNetCore.Bootstrap.Starter /DevExpress.AspNetCore.Bootstrap.Starter

WORKDIR /DevExpress.AspNetCore.Bootstrap.Starter

RUN dotnet restore

RUN dotnet publish --output /app/ --configuration Release


FROM microsoft/aspnetcore:2.0.0

WORKDIR /app

COPY --from=builder /app .

COPY --from=builder /DevExpress.AspNetCore.Bootstrap.Starter/App_Data App_Data

ENTRYPOINT ["dotnet", "DevExpress.AspNetCore.Bootstrap.Starter.dll"]